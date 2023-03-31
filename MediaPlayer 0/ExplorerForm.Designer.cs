namespace MediaPlayer_0
{
    partial class ExplorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FolderlstStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FolderLst = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataModifey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoldelstMenuStr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripFoldelstMenuStrOpnbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FoldelstMenuStrViewTitlebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderTitleViewbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderLargIconViewbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderSmallIconViewbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderDetailesViewbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderListViewbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderSortByNamebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderSortByPathbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderSortByDateModifeybtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FolderAscbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderDscbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.LargIcon = new System.Windows.Forms.ImageList(this.components);
            this.SmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.PlayLst = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataModifeyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayLstMenuStr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayTitleViewModebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayLargIconViewModebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaySmallIconViewModebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDetailesViewModebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayListViewModebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaySortByNamebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaySortBySizebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaySortByExtenchionbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaySortByDateModifeybtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayAscbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayDscbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderDialong = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.FolderlstStatusBar.SuspendLayout();
            this.FoldelstMenuStr.SuspendLayout();
            this.PlayLstMenuStr.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FolderlstStatusBar);
            this.splitContainer1.Panel1.Controls.Add(this.FolderLst);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PlayLst);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // FolderlstStatusBar
            // 
            this.FolderlstStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.FolderlstStatusBar.Location = new System.Drawing.Point(0, 404);
            this.FolderlstStatusBar.Name = "FolderlstStatusBar";
            this.FolderlstStatusBar.Size = new System.Drawing.Size(235, 22);
            this.FolderlstStatusBar.TabIndex = 3;
            this.FolderlstStatusBar.Text = "Hellos";
            this.FolderlstStatusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip2_ItemClicked);
            this.FolderlstStatusBar.Click += new System.EventHandler(this.FolderlstStatusBar_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel2.Text = "Items";
            // 
            // FolderLst
            // 
            this.FolderLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Path,
            this.DataModifey});
            this.FolderLst.ContextMenuStrip = this.FoldelstMenuStr;
            this.FolderLst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderLst.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FolderLst.HideSelection = false;
            this.FolderLst.LargeImageList = this.LargIcon;
            this.FolderLst.Location = new System.Drawing.Point(0, 0);
            this.FolderLst.MultiSelect = false;
            this.FolderLst.Name = "FolderLst";
            this.FolderLst.Size = new System.Drawing.Size(235, 426);
            this.FolderLst.SmallImageList = this.SmallIcon;
            this.FolderLst.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.FolderLst.TabIndex = 0;
            this.FolderLst.UseCompatibleStateImageBehavior = false;
            this.FolderLst.View = System.Windows.Forms.View.Tile;
            this.FolderLst.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.FolderLst_ColumnClick);
            this.FolderLst.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FolderLst_ItemCheck);
            this.FolderLst.SelectedIndexChanged += new System.EventHandler(this.FolderLst_SelectedIndexChanged);
            this.FolderLst.DoubleClick += new System.EventHandler(this.FolderLst_DoubleClick);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 191;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 200;
            // 
            // DataModifey
            // 
            this.DataModifey.Text = "Data Modifey";
            this.DataModifey.Width = 120;
            // 
            // FoldelstMenuStr
            // 
            this.FoldelstMenuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripFoldelstMenuStrOpnbtn,
            this.searchToolStripMenuItem2,
            this.toolStripSeparator3,
            this.FoldelstMenuStrViewTitlebtn,
            this.sortByToolStripMenuItem});
            this.FoldelstMenuStr.Name = "contextMenuStrip1";
            this.FoldelstMenuStr.Size = new System.Drawing.Size(125, 98);
            // 
            // openToolStripFoldelstMenuStrOpnbtn
            // 
            this.openToolStripFoldelstMenuStrOpnbtn.Name = "openToolStripFoldelstMenuStrOpnbtn";
            this.openToolStripFoldelstMenuStrOpnbtn.Size = new System.Drawing.Size(124, 22);
            this.openToolStripFoldelstMenuStrOpnbtn.Text = "Open File";
            this.openToolStripFoldelstMenuStrOpnbtn.Click += new System.EventHandler(this.FoldelstMenuStr_Click);
            // 
            // searchToolStripMenuItem2
            // 
            this.searchToolStripMenuItem2.Name = "searchToolStripMenuItem2";
            this.searchToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.searchToolStripMenuItem2.Text = "Search";
            this.searchToolStripMenuItem2.Click += new System.EventHandler(this.searchToolStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // FoldelstMenuStrViewTitlebtn
            // 
            this.FoldelstMenuStrViewTitlebtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderTitleViewbtn,
            this.FolderLargIconViewbtn,
            this.FolderSmallIconViewbtn,
            this.FolderDetailesViewbtn,
            this.FolderListViewbtn});
            this.FoldelstMenuStrViewTitlebtn.Name = "FoldelstMenuStrViewTitlebtn";
            this.FoldelstMenuStrViewTitlebtn.Size = new System.Drawing.Size(124, 22);
            this.FoldelstMenuStrViewTitlebtn.Text = "View";
            // 
            // FolderTitleViewbtn
            // 
            this.FolderTitleViewbtn.Checked = true;
            this.FolderTitleViewbtn.CheckOnClick = true;
            this.FolderTitleViewbtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FolderTitleViewbtn.Name = "FolderTitleViewbtn";
            this.FolderTitleViewbtn.Size = new System.Drawing.Size(132, 22);
            this.FolderTitleViewbtn.Text = "Title";
            this.FolderTitleViewbtn.Click += new System.EventHandler(this.FoldelstMenuStrViewTitlebtn_Click);
            // 
            // FolderLargIconViewbtn
            // 
            this.FolderLargIconViewbtn.Name = "FolderLargIconViewbtn";
            this.FolderLargIconViewbtn.Size = new System.Drawing.Size(132, 22);
            this.FolderLargIconViewbtn.Text = "LargeIcon";
            this.FolderLargIconViewbtn.Click += new System.EventHandler(this.FoldelstMenuStrViewLargIconebtn_Click);
            // 
            // FolderSmallIconViewbtn
            // 
            this.FolderSmallIconViewbtn.Name = "FolderSmallIconViewbtn";
            this.FolderSmallIconViewbtn.Size = new System.Drawing.Size(132, 22);
            this.FolderSmallIconViewbtn.Text = "Smaill Icon";
            this.FolderSmallIconViewbtn.Click += new System.EventHandler(this.FoldelstMenuStrViewSmallconebtn_Click);
            // 
            // FolderDetailesViewbtn
            // 
            this.FolderDetailesViewbtn.Name = "FolderDetailesViewbtn";
            this.FolderDetailesViewbtn.Size = new System.Drawing.Size(132, 22);
            this.FolderDetailesViewbtn.Text = "Detailes";
            this.FolderDetailesViewbtn.Click += new System.EventHandler(this.FoldelstMenuStrViewListsbtn_Click);
            // 
            // FolderListViewbtn
            // 
            this.FolderListViewbtn.Name = "FolderListViewbtn";
            this.FolderListViewbtn.Size = new System.Drawing.Size(132, 22);
            this.FolderListViewbtn.Text = "List";
            this.FolderListViewbtn.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderSortByNamebtn,
            this.FolderSortByPathbtn,
            this.FolderSortByDateModifeybtn,
            this.toolStripSeparator1,
            this.FolderAscbtn,
            this.FolderDscbtn});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // FolderSortByNamebtn
            // 
            this.FolderSortByNamebtn.Checked = true;
            this.FolderSortByNamebtn.CheckOnClick = true;
            this.FolderSortByNamebtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FolderSortByNamebtn.Name = "FolderSortByNamebtn";
            this.FolderSortByNamebtn.Size = new System.Drawing.Size(145, 22);
            this.FolderSortByNamebtn.Text = "Name";
            this.FolderSortByNamebtn.Click += new System.EventHandler(this.FoldelstMenuStrSortByNamebtn_Click);
            // 
            // FolderSortByPathbtn
            // 
            this.FolderSortByPathbtn.CheckOnClick = true;
            this.FolderSortByPathbtn.Name = "FolderSortByPathbtn";
            this.FolderSortByPathbtn.Size = new System.Drawing.Size(145, 22);
            this.FolderSortByPathbtn.Text = "Path";
            this.FolderSortByPathbtn.Click += new System.EventHandler(this.FoldelstMenuStrSortByPathbtn_Click);
            // 
            // FolderSortByDateModifeybtn
            // 
            this.FolderSortByDateModifeybtn.CheckOnClick = true;
            this.FolderSortByDateModifeybtn.Name = "FolderSortByDateModifeybtn";
            this.FolderSortByDateModifeybtn.Size = new System.Drawing.Size(145, 22);
            this.FolderSortByDateModifeybtn.Text = "Date Modifey";
            this.FolderSortByDateModifeybtn.Click += new System.EventHandler(this.FoldelstMenuStrDateModbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // FolderAscbtn
            // 
            this.FolderAscbtn.Checked = true;
            this.FolderAscbtn.CheckOnClick = true;
            this.FolderAscbtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FolderAscbtn.Name = "FolderAscbtn";
            this.FolderAscbtn.ShortcutKeyDisplayString = "";
            this.FolderAscbtn.Size = new System.Drawing.Size(145, 22);
            this.FolderAscbtn.Text = "Ascending";
            this.FolderAscbtn.Click += new System.EventHandler(this.FoldelstMenuStrSortAscebtn_Click);
            // 
            // FolderDscbtn
            // 
            this.FolderDscbtn.CheckOnClick = true;
            this.FolderDscbtn.Name = "FolderDscbtn";
            this.FolderDscbtn.Size = new System.Drawing.Size(145, 22);
            this.FolderDscbtn.Text = "Descending";
            this.FolderDscbtn.Click += new System.EventHandler(this.FoldelstMenuStrSortByNamebtn_Click_1);
            // 
            // LargIcon
            // 
            this.LargIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargIcon.ImageStream")));
            this.LargIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.LargIcon.Images.SetKeyName(0, "LargIcon.ico");
            // 
            // SmallIcon
            // 
            this.SmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIcon.ImageStream")));
            this.SmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIcon.Images.SetKeyName(0, "SmallIcon.ico");
            this.SmallIcon.Images.SetKeyName(1, "icons8_vegas_96px_1.png");
            // 
            // PlayLst
            // 
            this.PlayLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.SizeCol,
            this.DataModifeyCol,
            this.ExtCol});
            this.PlayLst.ContextMenuStrip = this.PlayLstMenuStr;
            this.PlayLst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayLst.Font = new System.Drawing.Font("Tahoma", 10F);
            this.PlayLst.HideSelection = false;
            this.PlayLst.LargeImageList = this.imageList1;
            this.PlayLst.Location = new System.Drawing.Point(0, 0);
            this.PlayLst.Name = "PlayLst";
            this.PlayLst.Size = new System.Drawing.Size(564, 426);
            this.PlayLst.SmallImageList = this.imageList2;
            this.PlayLst.TabIndex = 1;
            this.PlayLst.UseCompatibleStateImageBehavior = false;
            this.PlayLst.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.PlayListLst_ColumnClick);
            this.PlayLst.DoubleClick += new System.EventHandler(this.PlayListLst_DoubleClick);
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 170;
            // 
            // SizeCol
            // 
            this.SizeCol.Text = "Size";
            this.SizeCol.Width = 80;
            // 
            // DataModifeyCol
            // 
            this.DataModifeyCol.Text = "Data Modifey";
            this.DataModifeyCol.Width = 120;
            // 
            // ExtCol
            // 
            this.ExtCol.Text = "Extencton";
            this.ExtCol.Width = 100;
            // 
            // PlayLstMenuStr
            // 
            this.PlayLstMenuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem8});
            this.PlayLstMenuStr.Name = "contextMenuStrip1";
            this.PlayLstMenuStr.Size = new System.Drawing.Size(112, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayTitleViewModebtn,
            this.PlayLargIconViewModebtn,
            this.PlaySmallIconViewModebtn,
            this.PlayDetailesViewModebtn,
            this.PlayListViewModebtn});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem2.Text = "View";
            // 
            // PlayTitleViewModebtn
            // 
            this.PlayTitleViewModebtn.Name = "PlayTitleViewModebtn";
            this.PlayTitleViewModebtn.Size = new System.Drawing.Size(132, 22);
            this.PlayTitleViewModebtn.Text = "Title";
            this.PlayTitleViewModebtn.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // PlayLargIconViewModebtn
            // 
            this.PlayLargIconViewModebtn.Name = "PlayLargIconViewModebtn";
            this.PlayLargIconViewModebtn.Size = new System.Drawing.Size(132, 22);
            this.PlayLargIconViewModebtn.Text = "LargeIcon";
            this.PlayLargIconViewModebtn.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // PlaySmallIconViewModebtn
            // 
            this.PlaySmallIconViewModebtn.Name = "PlaySmallIconViewModebtn";
            this.PlaySmallIconViewModebtn.Size = new System.Drawing.Size(132, 22);
            this.PlaySmallIconViewModebtn.Text = "Smaill Icon";
            this.PlaySmallIconViewModebtn.Click += new System.EventHandler(this.ToolStripMenuItem5_Click_1);
            // 
            // PlayDetailesViewModebtn
            // 
            this.PlayDetailesViewModebtn.Name = "PlayDetailesViewModebtn";
            this.PlayDetailesViewModebtn.Size = new System.Drawing.Size(132, 22);
            this.PlayDetailesViewModebtn.Text = "Detailes";
            this.PlayDetailesViewModebtn.Click += new System.EventHandler(this.ToolStripMenuItem6_Click_1);
            // 
            // PlayListViewModebtn
            // 
            this.PlayListViewModebtn.Name = "PlayListViewModebtn";
            this.PlayListViewModebtn.Size = new System.Drawing.Size(132, 22);
            this.PlayListViewModebtn.Text = "List";
            this.PlayListViewModebtn.Click += new System.EventHandler(this.ToolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlaySortByNamebtn,
            this.PlaySortBySizebtn,
            this.PlaySortByExtenchionbtn,
            this.PlaySortByDateModifeybtn,
            this.toolStripSeparator2,
            this.PlayAscbtn,
            this.PlayDscbtn});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem8.Text = "Sort By";
            // 
            // PlaySortByNamebtn
            // 
            this.PlaySortByNamebtn.Checked = true;
            this.PlaySortByNamebtn.CheckOnClick = true;
            this.PlaySortByNamebtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlaySortByNamebtn.Name = "PlaySortByNamebtn";
            this.PlaySortByNamebtn.Size = new System.Drawing.Size(145, 22);
            this.PlaySortByNamebtn.Text = "Name";
            this.PlaySortByNamebtn.Click += new System.EventHandler(this.ToolStripMenuItem9_Click);
            // 
            // PlaySortBySizebtn
            // 
            this.PlaySortBySizebtn.Name = "PlaySortBySizebtn";
            this.PlaySortBySizebtn.Size = new System.Drawing.Size(145, 22);
            this.PlaySortBySizebtn.Text = "Size";
            this.PlaySortBySizebtn.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // PlaySortByExtenchionbtn
            // 
            this.PlaySortByExtenchionbtn.Name = "PlaySortByExtenchionbtn";
            this.PlaySortByExtenchionbtn.Size = new System.Drawing.Size(145, 22);
            this.PlaySortByExtenchionbtn.Text = "Extenchion";
            this.PlaySortByExtenchionbtn.Click += new System.EventHandler(this.extenchionToolStripMenuItem_Click);
            // 
            // PlaySortByDateModifeybtn
            // 
            this.PlaySortByDateModifeybtn.CheckOnClick = true;
            this.PlaySortByDateModifeybtn.Name = "PlaySortByDateModifeybtn";
            this.PlaySortByDateModifeybtn.Size = new System.Drawing.Size(145, 22);
            this.PlaySortByDateModifeybtn.Text = "Date Modifey";
            this.PlaySortByDateModifeybtn.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // PlayAscbtn
            // 
            this.PlayAscbtn.Checked = true;
            this.PlayAscbtn.CheckOnClick = true;
            this.PlayAscbtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayAscbtn.Name = "PlayAscbtn";
            this.PlayAscbtn.ShortcutKeyDisplayString = "";
            this.PlayAscbtn.Size = new System.Drawing.Size(145, 22);
            this.PlayAscbtn.Text = "Ascending";
            this.PlayAscbtn.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // PlayDscbtn
            // 
            this.PlayDscbtn.CheckOnClick = true;
            this.PlayDscbtn.Name = "PlayDscbtn";
            this.PlayDscbtn.Size = new System.Drawing.Size(145, 22);
            this.PlayDscbtn.Text = "Descending";
            this.PlayDscbtn.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_vegas_96px_1.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8_video_96px.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem,
            this.searchToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open File";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FolderDialong
            // 
            this.FolderDialong.Description = "Chose a folder ";
            // 
            // ExplorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Text = "MediaPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExplorerForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.FolderlstStatusBar.ResumeLayout(false);
            this.FolderlstStatusBar.PerformLayout();
            this.FoldelstMenuStr.ResumeLayout(false);
            this.PlayLstMenuStr.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView PlayLst;
        private System.Windows.Forms.ListView FolderLst;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FoldelstMenuStr;
        private System.Windows.Forms.ToolStripMenuItem FoldelstMenuStrViewTitlebtn;
        private System.Windows.Forms.ToolStripMenuItem FolderListViewbtn;
        private System.Windows.Forms.ToolStripMenuItem FolderDetailesViewbtn;
        private System.Windows.Forms.ToolStripMenuItem FolderLargIconViewbtn;
        private System.Windows.Forms.ToolStripMenuItem FolderSmallIconViewbtn;
        private System.Windows.Forms.ToolStripMenuItem FolderTitleViewbtn;
        private System.Windows.Forms.FolderBrowserDialog FolderDialong;
        private System.Windows.Forms.ImageList LargIcon;
        private System.Windows.Forms.ImageList SmallIcon;
        private new System.Windows.Forms.ColumnHeader  Name;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ToolStripMenuItem openToolStripFoldelstMenuStrOpnbtn;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FolderSortByNamebtn;
        private System.Windows.Forms.ToolStripMenuItem FolderSortByPathbtn;
        private System.Windows.Forms.ToolStripMenuItem FolderSortByDateModifeybtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FolderAscbtn;
        private System.Windows.Forms.ToolStripMenuItem FolderDscbtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip PlayLstMenuStr;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem PlayTitleViewModebtn;
        private System.Windows.Forms.ToolStripMenuItem PlayLargIconViewModebtn;
        private System.Windows.Forms.ToolStripMenuItem PlaySmallIconViewModebtn;
        private System.Windows.Forms.ToolStripMenuItem PlayDetailesViewModebtn;
        private System.Windows.Forms.ToolStripMenuItem PlayListViewModebtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem PlaySortByNamebtn;
        private System.Windows.Forms.ToolStripMenuItem PlaySortByDateModifeybtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PlayAscbtn;
        private System.Windows.Forms.ToolStripMenuItem PlayDscbtn;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader SizeCol;
        private System.Windows.Forms.ColumnHeader ExtCol;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripMenuItem PlaySortBySizebtn;
        private System.Windows.Forms.ToolStripMenuItem PlaySortByExtenchionbtn;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader DataModifey;
        private System.Windows.Forms.ColumnHeader DataModifeyCol;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip FolderlstStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

