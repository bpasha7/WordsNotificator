using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MyWordsNotificator
{
    delegate void ShowAlertInvoker(string caption, string text);

    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        ApplicationContext db;
        MySettings _settings;
        private static System.Threading.Timer _timer;
        BindingList<MyWord> _words = null;
        MyWord lastWord;
        bool pause = false;

        List<MyWord> _cache = new List<MyWord>();

        public MainForm()
        {
            InitializeComponent();
            _settings = new MySettings();
            var startTimeSpan = new TimeSpan(0, 0, 30);
            var periodTimeSpan = _settings.Times["INTERVAL"];
#if DEBUG
            periodTimeSpan = TimeSpan.FromSeconds(15);
#endif
            _timer = new System.Threading.Timer((e) =>
            {
                ShowTip();
            }, null, startTimeSpan, periodTimeSpan);
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            if (e.Item.Id != 3)
                navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void ShowTip()
        {
            var dt = DateTime.Now;
            if (pause)
                return;
            if (!_settings.Days[dt.DayOfWeek.ToString().ToUpper()])
                return;
            if (dt.TimeOfDay > _settings.Times["TILL"] || dt.TimeOfDay < _settings.Times["FROM"])
                return;
            db = new ApplicationContext();
            if (_cache.Count == 0)
            {
                _cache = db.Dictionary.Where(i => !i.Skip).OrderBy(o => o.LastTick).Take(10).ToList();
            }
            var item = _cache[0];
            lastWord = item;
            ShowAlert(item.Word, item.Description);
            item.Shown++;
            item.LastTick = DateTime.Now;
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            _cache.RemoveAt(0);

        }

        private void ShowAlert(string caption, string text)
        {
            if (this.InvokeRequired)
                this.Invoke(new ShowAlertInvoker(ShowAlert), caption, text);
            else
                alertControl.Show(this, caption, text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //#if !DEBUG
            LoadDictionary();
            //#endif
        }

        private void ShowSettings()
        {
            if (_settings.Times.Count != 0)
                intervalEdit.EditValue = _settings.Times["INTERVAL"];
            if (_settings.Days.Count != 0)
            {
                useScheduleEdit.Checked = _settings.Days["SCHEDULE"];
                fromEdit.EditValue = _settings.Times["FROM"];
                tillEdit.EditValue = _settings.Times["TILL"];
                MondayEdit.Checked = _settings.Days["MONDAY"];
                TuesdayEdit.Checked = _settings.Days["TUESDAY"];
                WednesdayEdit.Checked = _settings.Days["WEDNESDAY"];
                ThursdayEdit.Checked = _settings.Days["THURSDAY"];
                FridayEdit.Checked = _settings.Days["FRIDAY"];
                SaturdayEdit.Checked = _settings.Days["SATURDSY"];
                SundayEdit.Checked = _settings.Days["SUNDAY"];
            }
        }
        private void SaveSettings()
        {
            if (_settings.Times.Count != 0)
                _settings.Times["INTERVAL"] = (TimeSpan)intervalEdit.EditValue;
            if (_settings.Days.Count != 0)
            {
                _settings.Days["SCHEDULE"] = useScheduleEdit.Checked;
                _settings.Times["FROM"] = (TimeSpan)fromEdit.EditValue;
                _settings.Times["TILL"] = (TimeSpan)tillEdit.EditValue;

                MondayEdit.Checked = _settings.Days["MONDAY"];
                TuesdayEdit.Checked = _settings.Days["TUESDAY"];
                WednesdayEdit.Checked = _settings.Days["WEDNESDAY"];
                ThursdayEdit.Checked = _settings.Days["THURSDAY"];
                FridayEdit.Checked = _settings.Days["FRIDAY"];
                SaturdayEdit.Checked = _settings.Days["SATURDSY"];
                SundayEdit.Checked = _settings.Days["SUNDAY"];
            }
        }

        private void WordsTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            if (_words == null)
            {
                LoadDictionary();
            }
        }

        public void LoadDictionary()
        {
            db = new ApplicationContext();
            var dic = db.Dictionary.OrderBy(o => o.Word).ToList();
            _words = new BindingList<MyWord>(dic);
            _words.AllowNew = true;
            _words.AllowEdit = true;
            gcWords.DataSource = _words;
        }

        private void gvWords_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var word = e.Row as MyWord;
            db = new ApplicationContext();
            if (word.Id == 0 && word.Word != "" && word.Description != "")
            {
                word.LastTick = DateTime.Now;
                db.Dictionary.Add(word);
                db.SaveChanges();
            }
            else if (word.Id != 0)
            {
                db.Entry(word).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void gcWords_Click(object sender, EventArgs e)
        {

        }

        private void tileBar_Click(object sender, EventArgs e)
        {

        }

        private void WordsTileBarItem_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            LoadDictionary();
        }

        private void hideBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTip();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void useScheduleEdit_CheckedChanged(object sender, EventArgs e)
        {
            scheduleControl.Enabled = useScheduleEdit.Checked;
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void settingsTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowSettings();
        }

        private void alertControl_ButtonClick(object sender, DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs e)
        {
            if (lastWord == null)
                return;
            if (e.ButtonName == "translateBtn")
            {
                System.Diagnostics.Process.Start("https://translate.google.ru/?hl=ru#en/ru/" + lastWord.Word);
            }
            if (e.ButtonName == "deleteBtn")
            {
                db = new ApplicationContext();
                lastWord.Skip = true;
                db.Entry(lastWord).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            continueToolStripMenuItem.Visible = true;
            pauseToolStripMenuItem.Visible = false;
            pause = true;

        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            continueToolStripMenuItem.Visible = false;
            pauseToolStripMenuItem.Visible = true;
            pause = false;
        }
    }
}