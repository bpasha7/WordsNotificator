namespace MyWordsNotificator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.WordsTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.settingsTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.hideBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gcWords = new DevExpress.XtraGrid.GridControl();
            this.gvWords = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShown = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.notifyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileBar.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBar.AppearanceText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileBar.AppearanceText.Options.UseFont = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tileBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.tileBar.Location = new System.Drawing.Point(0, 296);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 4;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 70);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 85);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(444, 85);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            this.tileBar.Click += new System.EventHandler(this.tileBar_Click);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.WordsTileBarItem);
            this.tileBarGroupTables.Items.Add(this.settingsTileBarItem);
            this.tileBarGroupTables.Items.Add(this.hideBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // WordsTileBarItem
            // 
            this.WordsTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.WordsTileBarItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.WordsTileBarItem.AppearanceItem.Normal.Options.UseFont = true;
            this.WordsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = global::MyWordsNotificator.Properties.Resources._3d_dictionary;
            tileItemElement1.Text = "Dictionary";
            this.WordsTileBarItem.Elements.Add(tileItemElement1);
            this.WordsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.WordsTileBarItem.Name = "WordsTileBarItem";
            this.WordsTileBarItem.ShowItemShadow = DevExpress.Utils.DefaultBoolean.False;
            this.WordsTileBarItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.WordsTileBarItem_ItemClick);
            this.WordsTileBarItem.ItemDoubleClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.WordsTileBarItem_ItemDoubleClick);
            // 
            // settingsTileBarItem
            // 
            this.settingsTileBarItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsTileBarItem.AppearanceItem.Normal.Options.UseFont = true;
            this.settingsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.Text = "Settings";
            this.settingsTileBarItem.Elements.Add(tileItemElement2);
            this.settingsTileBarItem.Id = 2;
            this.settingsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.settingsTileBarItem.Name = "settingsTileBarItem";
            // 
            // hideBarItem
            // 
            this.hideBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.hideBarItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.hideBarItem.AppearanceItem.Normal.Options.UseFont = true;
            this.hideBarItem.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.hideBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = global::MyWordsNotificator.Properties.Resources.minimize;
            tileItemElement3.Text = "Hide";
            this.hideBarItem.Elements.Add(tileItemElement3);
            this.hideBarItem.Id = 3;
            this.hideBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.hideBarItem.Name = "hideBarItem";
            toolTipItem1.Text = "Hide window";
            superToolTip1.Items.Add(toolTipItem1);
            this.hideBarItem.SuperTip = superToolTip1;
            this.hideBarItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.hideBarItem_ItemClick);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(444, 296);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Controls.Add(this.gcWords);
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(444, 296);
            // 
            // gcWords
            // 
            this.gcWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcWords.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gcWords.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcWords.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcWords.EmbeddedNavigator.Text = "Word";
            this.gcWords.Location = new System.Drawing.Point(0, 0);
            this.gcWords.MainView = this.gvWords;
            this.gcWords.Name = "gcWords";
            this.gcWords.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcWords.Size = new System.Drawing.Size(444, 296);
            this.gcWords.TabIndex = 3;
            this.gcWords.UseEmbeddedNavigator = true;
            this.gcWords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWords});
            this.gcWords.Click += new System.EventHandler(this.gcWords_Click);
            // 
            // gvWords
            // 
            this.gvWords.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gvWords.Appearance.GroupPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gvWords.Appearance.GroupPanel.Options.UseFont = true;
            this.gvWords.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvWords.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colWord,
            this.colDescription,
            this.colShown,
            this.colSkip});
            this.gvWords.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvWords.GridControl = this.gcWords;
            this.gvWords.GroupPanelText = "My dictionary";
            this.gvWords.Name = "gvWords";
            this.gvWords.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvWords.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvWords.OptionsView.ShowFooter = true;
            this.gvWords.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvWords_RowUpdated);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 25;
            // 
            // colWord
            // 
            this.colWord.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWord.AppearanceCell.Options.UseFont = true;
            this.colWord.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWord.AppearanceHeader.Options.UseFont = true;
            this.colWord.AppearanceHeader.Options.UseTextOptions = true;
            this.colWord.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWord.Caption = "Word";
            this.colWord.FieldName = "Word";
            this.colWord.MaxWidth = 100;
            this.colWord.MinWidth = 70;
            this.colWord.Name = "colWord";
            this.colWord.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Word", "Count: {0}")});
            this.colWord.Visible = true;
            this.colWord.VisibleIndex = 0;
            this.colWord.Width = 70;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 70;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 150;
            // 
            // colShown
            // 
            this.colShown.AppearanceCell.Options.UseTextOptions = true;
            this.colShown.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShown.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colShown.AppearanceHeader.Options.UseFont = true;
            this.colShown.AppearanceHeader.Options.UseTextOptions = true;
            this.colShown.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShown.Caption = "Shown";
            this.colShown.FieldName = "Shown";
            this.colShown.MaxWidth = 50;
            this.colShown.MinWidth = 50;
            this.colShown.Name = "colShown";
            this.colShown.Visible = true;
            this.colShown.VisibleIndex = 2;
            this.colShown.Width = 50;
            // 
            // colSkip
            // 
            this.colSkip.AppearanceCell.Options.UseTextOptions = true;
            this.colSkip.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSkip.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSkip.AppearanceHeader.Options.UseFont = true;
            this.colSkip.AppearanceHeader.Options.UseTextOptions = true;
            this.colSkip.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSkip.Caption = "Skip";
            this.colSkip.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSkip.FieldName = "Skip";
            this.colSkip.MaxWidth = 45;
            this.colSkip.MinWidth = 45;
            this.colSkip.Name = "colSkip";
            this.colSkip.Visible = true;
            this.colSkip.VisibleIndex = 3;
            this.colSkip.Width = 45;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCheckEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(444, 296);
            this.employeesLabelControl.TabIndex = 2;
            this.employeesLabelControl.Text = "Words";
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(444, 296);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(444, 296);
            this.customersLabelControl.TabIndex = 2;
            this.customersLabelControl.Text = "Settings";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Word";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "My words trainer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // notifyMenuStrip
            // 
            this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.continueToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.notifyMenuStrip.Name = "notifyMenuStrip";
            this.notifyMenuStrip.Size = new System.Drawing.Size(129, 98);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.showToolStripMenuItem.Text = "Show next";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // continueToolStripMenuItem
            // 
            this.continueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("continueToolStripMenuItem.Image")));
            this.continueToolStripMenuItem.Name = "continueToolStripMenuItem";
            this.continueToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.continueToolStripMenuItem.Text = "Continue";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseToolStripMenuItem.Image")));
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Appearance.BorderColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 381);
            this.ControlBox = false;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My words trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.notifyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem WordsTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem settingsTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraGrid.GridControl gcWords;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWords;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colWord;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colShown;
        private DevExpress.XtraGrid.Columns.GridColumn colSkip;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.Navigation.TileBarItem hideBarItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continueToolStripMenuItem;
    }
}