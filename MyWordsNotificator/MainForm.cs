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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        ApplicationContext db;

        BindingList<MyWord> _words = null;

        public MainForm()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            if(e.Item.Id != 3)
                navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
#if !DEBUG
            LoadDictionary();
#endif
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
            this.Show();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close application?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
    }
}