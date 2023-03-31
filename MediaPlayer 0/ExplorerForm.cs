using MediaPlayer_0.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
namespace MediaPlayer_0
{

    public partial class ExplorForm : Form
    {
        //Variables To Hold The Values Of The User Settings For Folder List
        private string FolderSort;      //The Sort Mode 
        private bool FolderAscending;   //The Sort Order
        private View FolderView;        //The View Mode
       
        //Variables To Hold The Values Of The User Settings For Play List 
        private string PlaySort;        //The Sort Mode ;
        private View PlayView;          //The View Mode
        private bool PlayAscending;     //The Sort Order

        //string[] ext;


        public ExplorForm()    
        {
            
            InitializeComponent();
            
            Program.Files = new List<FileInfo>();
            
            //Get The User Settings For Folder List
            FolderSort = Settings.Default.FolderSort;               //Get The Sort Mode;
            FolderView = Settings.Default.FolderView;               //Get The Folder View Mode
            FolderAscending = Settings.Default.FolderAscending;     //Get The Sort Order

            //Get The User Settings For Play List
            PlaySort = Settings.Default.PlaySort;               //Get The Sort Mode;
            PlayView = Settings.Default.PlayView;               //Get The Sort Mode;
            PlayAscending = Settings.Default.PlayAscending;     //Get The Sort Mode;

            //List That Contain The New Folders
            Program.NewFolders = new List<DirectoryInfo>();

            //DropEmptyFolders();
            SetDirectories(Program.Folders);
            //FolderlstStatusBar
            toolStripStatusLabel2.Text = FolderLst.Items.Count.ToString()+" Folders";
            
        }




        private void Form1_Load(object sender, EventArgs e)
        {


            //Set The User Settings For The Folder List 

                FolderLst.View = FolderView;                                        //Set The View Mode
                Sort(new SortDevenition(), FolderLst, FolderAscending, FolderSort); //Set The Sort Mode
                //Set The ToolTip
                ChickFolderViewTollTip(FolderView.ToString());      
                ChickFolderSortTollTip(FolderSort,FolderAscending);


            //Set The User Settings For The Play List 

                PlayLst.View = PlayView;                          //Set The View Mode
                Sort(new SortDevenition(), PlayLst, PlayAscending, PlaySort);  //Set The Sort Mode
                //Set The ToolTip
                ChickPlayViewTollTip(PlayView.ToString());
                ChickPlaySortTollTip(PlaySort, PlayAscending);


        }

        public void VideoPlayer(Form Container)
        {
            //The Form Setting To Be Enable In Another Form
            Container.TopLevel = false;
            Container.BringToFront();
            Container.Dock = DockStyle.Fill;
            this.Controls.Add(Container);//Add The Form To The Main Form
            Container.Show();

        }
       
        public void SetDirectories(List <DirectoryInfo> folders)
        {
            foreach (DirectoryInfo folder in folders)
            {

                ListViewItem item = new ListViewItem
                {
                    ImageIndex = 0,
                    Text = folder.Name
                };
                item.SubItems.Add(folder.FullName);
                item.SubItems.Add(folder.LastAccessTime.ToString());

                FolderLst.Items.Add(item);

            }
        }

        private void ChickFolderViewTollTip(string temp)
        {
             
            switch (temp)
            {
                case "Title":

                    FolderTitleViewbtn.Checked = true;
                    FolderLargIconViewbtn.Checked = false;
                    FolderSmallIconViewbtn.Checked = false;
                    FolderDetailesViewbtn.Checked = false;
                    FolderListViewbtn.Checked = false;
                    break;
                case "LargeIcon":

                    FolderTitleViewbtn.Checked = false;
                    FolderLargIconViewbtn.Checked = true;
                    FolderSmallIconViewbtn.Checked = false;
                    FolderDetailesViewbtn.Checked = false;
                    FolderListViewbtn.Checked = false;
                    break;
                case "SmallIcon":

                    FolderTitleViewbtn.Checked = false;
                    FolderLargIconViewbtn.Checked = false;
                    FolderSmallIconViewbtn.Checked = true;
                    FolderDetailesViewbtn.Checked = false;
                    FolderListViewbtn.Checked = false;
                    break;
                case "Detailes":

                    FolderTitleViewbtn.Checked = false;
                    FolderLargIconViewbtn.Checked = false;
                    FolderSmallIconViewbtn.Checked = false;
                    FolderDetailesViewbtn.Checked = true;
                    FolderListViewbtn.Checked = false;
                    break;
                case "List":

                    FolderTitleViewbtn.Checked = false;
                    FolderLargIconViewbtn.Checked = false;
                    FolderSmallIconViewbtn.Checked = false;
                    FolderDetailesViewbtn.Checked = false;
                    FolderListViewbtn.Checked = true;
                    break;
               
            }
        }

        private void ChickFolderSortTollTip(string temp,bool Ascending)
        {
            if (Ascending)
            {
                FolderAscbtn.Checked = true;
                FolderDscbtn.Checked = false;
            }
            else
            {
                FolderAscbtn.Checked = false;
                FolderDscbtn.Checked = true;

            }


            switch (temp)
            {
                case "Name":

                    FolderSortByNamebtn.Checked = true;
                    FolderSortByPathbtn.Checked = false;
                    
                    break;
                case "Path":

                    FolderSortByNamebtn.Checked = false;
                    FolderSortByPathbtn.Checked = true;
                    break;
            }
        }

        private void ChickPlayViewTollTip(string temp)
        {
            switch (temp)
            {
                case "Tile":

                    PlayTitleViewModebtn.Checked = true;
                    PlayLargIconViewModebtn.Checked = false;
                    PlaySmallIconViewModebtn.Checked = false;
                    PlayDetailesViewModebtn.Checked = false;
                    PlayListViewModebtn.Checked = false;
                    break;
                case "LargeIcon":

                    PlayTitleViewModebtn.Checked = false;
                    PlayLargIconViewModebtn.Checked = true;
                    PlaySmallIconViewModebtn.Checked = false;
                    PlayDetailesViewModebtn.Checked = false;
                    PlayListViewModebtn.Checked = false;
                    break;
                case "SmallIcon":

                    PlayTitleViewModebtn.Checked = false;
                    PlayLargIconViewModebtn.Checked = false;
                    PlaySmallIconViewModebtn.Checked = true;
                    PlayDetailesViewModebtn.Checked = false;
                    PlayListViewModebtn.Checked = false;
                    break;
                case "Details":
                    PlayTitleViewModebtn.Checked = false;
                    PlayLargIconViewModebtn.Checked = false;
                    PlaySmallIconViewModebtn.Checked = false;
                    PlayDetailesViewModebtn.Checked = true;
                    PlayListViewModebtn.Checked = false;
                    break;
                case "List":
                    PlayTitleViewModebtn.Checked = false;
                    PlayLargIconViewModebtn.Checked = false;
                    PlaySmallIconViewModebtn.Checked = false;
                    PlayDetailesViewModebtn.Checked = false;
                    PlayListViewModebtn.Checked = true;
                    break;
               
            }
        }

        private void ChickPlaySortTollTip(string temp, bool Ascending)
        {
            if (Ascending)
            {
                PlayAscbtn.Checked = true;
                PlayDscbtn.Checked = false;
            }
            else
            {
                PlayAscbtn.Checked = false;
                PlayDscbtn.Checked = true;

            }


            switch (temp)
            {
                case "Name":

                    PlaySortByNamebtn.Checked = true;
                    PlaySortBySizebtn.Checked = false;
                    PlaySortByExtenchionbtn.Checked = false;
                    PlaySortByDateModifeybtn.Checked = false;

                    break;
                
                    
                case "Size":

                    PlaySortByNamebtn.Checked = false;
                    PlaySortBySizebtn.Checked = true;
                    PlaySortByExtenchionbtn.Checked = false;
                    PlaySortByDateModifeybtn.Checked = false;
                    break;
                case "Extenchion":

                    PlaySortByNamebtn.Checked = false;
                    PlaySortBySizebtn.Checked = false;
                    PlaySortByExtenchionbtn.Checked = true;
                    PlaySortByDateModifeybtn.Checked = false;
                    break;
                case "DateModifey":

                    PlaySortByNamebtn.Checked = false;
                    PlaySortBySizebtn.Checked = false;
                    PlaySortByExtenchionbtn.Checked = false;
                    PlaySortByDateModifeybtn.Checked = true;
                    break;

            }
        }

        private void FolderLst_DoubleClick(object sender, EventArgs e)
        {

            
            Program.Folder = new DirectoryInfo( FolderLst.FocusedItem.SubItems[1].Text);
            

            Program.Files = Program.Folder.EnumerateFiles().Where(s => Program.ext.Any(ext => ext == System.IO.Path.GetExtension(s.ToString()))); ;

            PlayLst.Items.Clear();
            foreach (FileInfo file in Program.Files)
            {
                if(File.Exists(file.FullName)==false)continue;
                ListViewItem item = new ListViewItem
                {
                    //Item Name
                    Text = file.Name,
                    //Item Image 
                    ImageIndex = 0
                };
                //Item size
                item.SubItems.Add(file.Length.ToString()+" byte");
                //Item Last Modified
                item.SubItems.Add(file.LastAccessTime.ToString());
                //Item Extenchion
                item.SubItems.Add(file.Extension);
                // Add The Item To The Play list 
                PlayLst.Items.Add(item);
            }


            
        }

        private void PlayListLst_DoubleClick(object sender, EventArgs e)
        {
            //Hide All The Controls In the Main Form;
            foreach (Control c in this.Controls)
                c.Hide();

            Program.VideoIndex =  PlayLst.FocusedItem.Index;//Smart;
            Program.ChosenVideo = PlayLst.FocusedItem.Text;

            VideoPlayer(new VideoPlayer());
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderTitleViewbtn.Checked = false;
            FolderLargIconViewbtn.Checked = false;
            FolderSmallIconViewbtn.Checked = false;
            FolderDetailesViewbtn.Checked = false;
            FolderListViewbtn.Checked = true;
            FolderLst.View = View.List ;
        }

        private void FoldelstMenuStrViewListsbtn_Click(object sender, EventArgs e)
        {
            FolderTitleViewbtn.Checked = false;
            FolderLargIconViewbtn.Checked = false;
            FolderSmallIconViewbtn.Checked = false;
            FolderDetailesViewbtn.Checked = true;
            FolderListViewbtn.Checked = false;
            FolderLst.View = View.Details;

        }

        private void FoldelstMenuStrViewLargIconebtn_Click(object sender, EventArgs e)
        {
            FolderTitleViewbtn.Checked = false;
            FolderLargIconViewbtn.Checked = true;
            FolderSmallIconViewbtn.Checked = false;
            FolderDetailesViewbtn.Checked = false;
            FolderListViewbtn.Checked = false;
            FolderLst.View = View.LargeIcon;

        }

        private void FoldelstMenuStrViewSmallconebtn_Click(object sender, EventArgs e)
        {
            FolderTitleViewbtn.Checked = false;
            FolderLargIconViewbtn.Checked = false;
            FolderSmallIconViewbtn.Checked = true;
            FolderDetailesViewbtn.Checked = false;
            FolderListViewbtn.Checked = false;
            FolderLst.View = View.SmallIcon;

        }

        private void FoldelstMenuStrViewTitlebtn_Click(object sender, EventArgs e)
        {
            FolderTitleViewbtn.Checked = true;
            FolderLargIconViewbtn.Checked = false;
            FolderSmallIconViewbtn.Checked = false;
            FolderDetailesViewbtn.Checked = false;
            FolderListViewbtn.Checked = false;
            FolderLst.View = View.Tile;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PlayLst.View = View.List;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PlayLst.View = View.Details;

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PlayLst.View = View.LargeIcon;

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PlayLst.View = View.SmallIcon;

        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PlayLst.View = View.SmallIcon;

        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFolderMethod();


        }

        private void FolderLst_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Get The Sort Mode
            FolderSort = e.Column.ToString();
            if (FolderSort == "1")FolderSort = "Path";
            
            //Sort The list view
            Sort(new SortDevenition(),FolderLst, FolderAscbtn.Checked, FolderSort);
            //ReChick For The Asce..& Decs... btns
            FolderAscbtn.Checked = !FolderAscbtn.Checked;

            if (FolderAscbtn.Checked)
                FolderDscbtn.Checked = false;
            else
                FolderDscbtn.Checked = true;



        }

        private void FoldelstMenuStr_Click(object sender, EventArgs e)
        {
            //Add a Folder To The Folder List
            OpenFolderMethod();

        }
        
        private void OpenFolderMethod()
        {
            //Open The Dialoge Folder To Selet a Folder
            //If The User Choice The Folder Get Into The IF Block 
            if (FolderDialong.ShowDialog() == DialogResult.OK)
            {
                
                Search s = new Search();

                //Get The Directory Informatchion About That Folder;
                DirectoryInfo folder = new DirectoryInfo(FolderDialong.SelectedPath);
                DialogResult IncludeSubFolders = MessageBox.Show("Do You Want To Include SubFolders ?", "Include SubFolders?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (IncludeSubFolders == DialogResult.Yes)
                {
                    s.SearchForFolders(folder);
                    s.DropEmptyFolders();
                    s.AddTo(Program.NewFolders);
                    
                    //FolderLst.Clear();

                    SetDirectories(Program.NewFolders);
                    return;
                }

                //If The Folder Has No Media To Play
                if (s.ChickFolder(folder) == 0)
                {
                    //Show The Message Box To Tell The User 
                    MessageBox.Show("The " + folder.Name + " Have No Media Files");
                    return;
                }


                Program.NewFolders.Add(folder);
                // create a new list view item 
                ListViewItem item = new ListViewItem
                {
                    //set the Icon
                    ImageIndex = 0,
                    // set the name
                    Text = folder.Name
                };

                //Set The Folder
                item.SubItems.Add(folder.FullName);
                item.SubItems.Add(folder.LastAccessTime.ToString());

                // Add To the Folder list
                FolderLst.Items.Add(item);

            }

        }
        
        private void FoldelstMenuStrSortByNamebtn_Click(object sender, EventArgs e)
        {
            FolderSortByNamebtn.Checked=true;
            FolderSort = "Name";

            FolderSortByPathbtn.Checked = false;
            FolderSortByDateModifeybtn.Checked = false;
            FolderSortByDateModifeybtn.Checked = false;
            Sort(new SortDevenition(),FolderLst, FolderAscbtn.Checked, FolderSort);
           


        }

        private void FoldelstMenuStrSortByPathbtn_Click(object sender, EventArgs e)
        {
            FolderSortByNamebtn.Checked = false;
            FolderSortByPathbtn.Checked = true;
            FolderSort = "Path";

            FolderSortByDateModifeybtn.Checked = false;
            Sort(new SortDevenition(),FolderLst, FolderAscbtn.Checked, FolderSort);
        }

        private void Sort(System.Collections.IComparer Type,ListView List, bool value, string SortMode)
        {
            SortDevenition temp = (SortDevenition) Type;
            temp.Ascending = value;
            temp.Mode = SortMode;
            List.ListViewItemSorter = temp;

        }
        
        private void FoldelstMenuStrSortByNamebtn_Click_1(object sender, EventArgs e)
        {

            FolderDscbtn.CheckState = CheckState.Checked;
            FolderAscbtn.CheckState = CheckState.Unchecked;
            FolderAscending = FolderAscbtn.Checked;

            Sort(new SortDevenition(),FolderLst, FolderAscending, FolderSort);
        }

        private void FoldelstMenuStrSortAscebtn_Click(object sender, EventArgs e)
        {
            FolderAscbtn.CheckState = CheckState.Checked;
            FolderDscbtn.CheckState = CheckState.Unchecked;
            FolderAscending = FolderAscbtn.Checked;
            Sort(new SortDevenition(),FolderLst, FolderAscending, FolderSort);
        }

        private void FoldelstMenuStrDateModbtn_Click(object sender, EventArgs e)
        {
            FolderSortByNamebtn.Checked = false;
            FolderSortByPathbtn.Checked = false;
            FolderSort = "DateModifey";
            FolderSortByDateModifeybtn.Checked = true;
            Sort(new SortDevenition(), FolderLst, FolderAscending, FolderSort);

        }

        private void FolderLst_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           //ToolStripItem item = (ToolStripItem)sender;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PlayListLst_DoubleClick(null, null);
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            PlayView = View.Tile;

            PlayTitleViewModebtn.Checked = true;
            PlayLargIconViewModebtn.Checked = false;
            PlaySmallIconViewModebtn.Checked = false;
            PlayDetailesViewModebtn.Checked = false;
            PlayListViewModebtn.Checked = false;
            PlayLst.View = PlayView;
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            PlayView = View.LargeIcon;

            PlayTitleViewModebtn.Checked = false;
            PlayLargIconViewModebtn.Checked = true;
            PlaySmallIconViewModebtn.Checked = false;
            PlayDetailesViewModebtn.Checked = false;
            PlayListViewModebtn.Checked = false;

            PlayLst.View = PlayView;

        }

        private void ToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            PlayView = View.SmallIcon;
            PlayTitleViewModebtn.Checked = false;
            PlayLargIconViewModebtn.Checked = false;
            PlaySmallIconViewModebtn.Checked = true;
            PlayDetailesViewModebtn.Checked = false;
            PlayListViewModebtn.Checked = false;

            PlayLst.View = PlayView;

        }

        private void ToolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            PlayView = View.Details;

            PlayTitleViewModebtn.Checked = false;
            PlayLargIconViewModebtn.Checked = false;
            PlaySmallIconViewModebtn.Checked = false;
            PlayDetailesViewModebtn.Checked = true;
            PlayListViewModebtn.Checked = false;

            PlayLst.View = PlayView;

        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            PlayView = View.List;

            PlayTitleViewModebtn.Checked = false;
            PlayLargIconViewModebtn.Checked = false;
            PlaySmallIconViewModebtn.Checked = false;
            PlayDetailesViewModebtn.Checked = false;
            PlayListViewModebtn.Checked = true;

            PlayLst.View = PlayView;

        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PlaySortByNamebtn.Checked = true;
            PlaySortBySizebtn.Checked = false;
            PlaySortByDateModifeybtn.Checked = false;
            PlaySortByExtenchionbtn.Checked = false;

            PlaySort = "Name";

            Sort(new SortDevenition(), PlayLst, PlayAscbtn.Checked, PlaySort);
            
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FolderSortByNamebtn.Checked = false;
            PlaySort = "Path";
            FolderSortByPathbtn.Checked = true;
            FolderSortByDateModifeybtn.Checked = false;
            Sort(new SortDevenition(), PlayLst, PlayAscbtn.Checked, PlaySort);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            PlayAscbtn.Checked = true;
            PlayDscbtn.Checked = false;
            PlayAscending = PlayAscbtn.Checked;
            Sort(new SortDevenition(), PlayLst, PlayAscending, PlaySort);


        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            PlayDscbtn.Checked = true;
            PlayAscbtn.Checked = false;
            PlayAscending = PlayAscbtn.Checked;

            Sort(new SortDevenition(), PlayLst, PlayAscending, PlaySort);


        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaySortByNamebtn.Checked = false;
            PlaySortBySizebtn.Checked = true;
            PlaySortByDateModifeybtn.Checked = false;
            PlaySortByExtenchionbtn.Checked = false;
            PlaySort = "Size";
            Sort(new SortDevenition(), PlayLst, PlayAscbtn.Checked, PlaySort);
        }

        private void extenchionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaySortByNamebtn.Checked = false;
            PlaySortBySizebtn.Checked = false;
            PlaySortByDateModifeybtn.Checked = false;
            PlaySortByExtenchionbtn.Checked = true;
            PlaySort = "Extenchion";
            Sort(new SortDevenition(), PlayLst, PlayAscbtn.Checked, PlaySort);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            PlaySortByNamebtn.Checked = false;
            PlaySortBySizebtn.Checked = false;
            PlaySortByDateModifeybtn.Checked = true;
            PlaySortByExtenchionbtn.Checked = false;

            PlaySort = "Extenchion";

            Sort(new SortDevenition(), PlayLst, PlayAscbtn.Checked, PlaySort);

        }

        private void PlayListLst_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // get The Sort Mode
            PlaySort = e.Column.ToString();         //
            switch (PlaySort)                       //
            {                                       //
                case "1":                           //
                    PlaySort = "Size";              //
                    break;                          //
                case "2":                           //
                    PlaySort = "Extenchion";        //
                    break;                          //
            }                                       //

            Sort(new SortDevenition(), PlayLst, PlayAscbtn.Checked, PlaySort);

            PlayAscbtn.Checked = !PlayAscbtn.Checked;
            if (PlayAscbtn.Checked)
                PlayDscbtn.Checked = false;
            else
                PlayDscbtn.Checked = true;
        }

        private void ExplorerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Get The User Setting
                //For The Folder List
                Settings.Default.FolderSort = FolderSort;               //Get Sort Mode 
                Settings.Default.FolderView = FolderLst.View;           //Get View Mode 
                Settings.Default.FolderAscending = FolderAscending;     //Get THe Sort Order


            //For The Play List 

            Settings.Default.PlaySort = PlaySort;               // Get The Sort Mode
                Settings.Default.PlayView = PlayView;               //Get The View Mode
                Settings.Default.PlayAscending = PlayAscending;     //Get The Sort Order


            //Save The Settings
            Settings.Default.Save();
            

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GID Team Development");
        }

        private void FolderLst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadingFolders_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

       
        private void OpenSearchForm()
        {
            SearchForm d = new SearchForm();
            d.ShowDialog();
            
            //FolderLst.Clear();

            SetDirectories(Program.NewFolders);

            

        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenSearchForm();

        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //LoadingFolders.RunWorkerAsync();
            OpenSearchForm();
        }

        private void Search_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            OpenSearchForm();

        }

        private void LoadingFolders_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
           //Control MyProgList= Application.OpenForms["SearchForm"].Controls.Find("progressBar1",false)[0] ;

           // MyProgList as ProgressBar;
           // MyProgList.value
                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void FolderlstStatusBar_Click(object sender, EventArgs e)
        {

        }
    }
}
