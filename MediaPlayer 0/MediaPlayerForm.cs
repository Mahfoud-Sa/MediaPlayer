using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVS.MediaPlayer;
using System.IO;
using MediaPlayer_0.Properties;

namespace MediaPlayer_0
{
    public partial class VideoPlayer : Form
    {
        
        Player p;//The Player That Play The The Video;
        List<FileInfo> PlayList;//The List Of Video Witch Will Be Playing;
        string PlayMode;//The Play Mode Of The List ;
        string SortMode; //The Sort Mode
        string ScreenDisplayMode; //The Display Mode For The Screen
        public VideoPlayer()
        {

            InitializeComponent();
            p = new Player(Screenpnl);
            p.CursorHide.Add(this);
            p.Events.MediaPositionChanged += MediaPoscitionState;
            //Folder = Program.Folder;
            p.TaskbarProgress.Add(this);
            //Get All The Vidoes In Folder
            PlayList = new List<FileInfo>();
            //VideoIndex = 0;
            PlayMode = Settings.Default.PlayMode;
            SortMode = Settings.Default.SortMode;
            ScreenDisplayMode = Settings.Default.ScreenDisplayMode;
            //Player Events
            p.Events.MediaEnded += new EventHandler<PVS.MediaPlayer.EndedEventArgs>(this.EndVideoEvent);
            p.Sliders.Position.TrackBar = trackBar3;
            p.Sliders.Position.Mode = PositionSliderMode.Track;

        }
        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            //Get All The Vieoes From The Folder
            PlayList = new List<FileInfo>(Program.Folder.EnumerateFiles().Where(s => Program.ext.Any(ext => ext == System.IO.Path.GetExtension(s.ToString()))));

            SortTheList(SortMode);

            ChickSortMode(SortMode);

            ChickPlayMode(PlayMode);

            ChickScreenDisplayMode(ScreenDisplayMode);
            Volumelbl.Text = trackBar2.Value.ToString();

            VideoLst.SelectedIndex = IndexOf(VideoLst, Program.ChosenVideo);

            Play();

            ChickPlayMode(PlayMode);
        }

        private void EndVideoEvent(object sender, EndedEventArgs e)
        {
            //An Event That Active When The Video Finish

           switch (e.StopReason)
            {
                
                case StopReason.Finished:
                    {
                        //When Play Mode Changed
                        switch (PlayMode)
                        {
                            case "Once":
                                p.Stop();
                                break;
                            case "Repeat":
                                Play();
                                break;
                            case "Play All":
                                Nxtbtn.PerformClick();
                                break;
                            case "Random":
                                {
                                    Random Temp = new Random();
                                    int dd = Temp.Next(VideoLst.Items.Count - 1);
                                    VideoLst.SelectedIndex = dd;
                                    Play();
                                }
                                break;
                            

                        }

                        break;
                    }

                case StopReason.UserStop:
                    MessageBox.Show("User Stop");

                    break;
                case StopReason.Error:
                    MessageBox.Show("Some Things Get Error");

                    break;
            }
        }
        
        private void MediaPoscitionState(object sender, PositionEventArgs e)
        {
            Stalbl.Text = TimeSpan.FromTicks(e.FromStart).ToString(@"hh\:mm\:ss");
            Endlbl.Text = TimeSpan.FromTicks(e.ToStop).ToString(@"hh\:mm\:ss");
        }

        private int IndexOf(ListBox List,string Item)
        {
            int index = -1;
            for(int i=0;i< List.Items.Count;i++)
            {
                
                if (List.Items[i].ToString() == Item)
                {
                    
                    index = i;
                    break;
                }
                    
                    
            }
            return index;
        }

        private void SetVideoLst()
        {
            VideoLst.Items.Clear();
            //Add The Videos To The Video List
            foreach (FileInfo Video in PlayList)
                VideoLst.Items.Add(Video);
        }

        private void VideoPlayer_Click(object sender, EventArgs e)
        {
            //panel3.Visible = !panel3.Visible;
            trackBar3.Visible = !trackBar3.Visible;
            Stalbl.Visible = !Stalbl.Visible;
            Endlbl.Visible = !Endlbl.Visible;

            //PausResbtn.PerformClick();

            //Revisible The Panales In The Video Screen;

            //Backbtn.Visible = !Backbtn.Visible;
            //panel1.Visible = !panel1.Visible;

            ////VolumeGB.Visible = !VolumeGB.Visible;

            //VideoLstbtn.Visible = !VideoLstbtn.Visible;

            //if (!VideoLstbtn.Visible)
            //    VideoLst.Visible = false;


        }

        private void Play()
        {
            string SelcetedVideo = Program.Folder + "\\" + VideoLst.SelectedItem.ToString();
            p.Play(SelcetedVideo);
        }
        private void VideoLstDoubleClick(object sender, EventArgs e)
        {
            Play();


        }

        private void PausResbtn_Click(object sender, EventArgs e)
        {

            if (p.Paused)
            {
                p.Resume();
                PausResbtn.Text = "Pause";
            }
            else
            {
                p.Pause();
                PausResbtn.Text = "Resume";
            }


        }

        private void Nxtbtn_Click(object sender, EventArgs e)
        {
            //To Play The Next Video 
            if (VideoLst.SelectedIndex + 1 == VideoLst.Items.Count)
            
                VideoLst.SelectedIndex = 0;
            
            else VideoLst.SelectedIndex += 1;


            Play();

        }

        private void Prebtn_Click(object sender, EventArgs e)
        {
            //To Play The Previoes Video

            if (VideoLst.SelectedIndex  == 0)

                VideoLst.SelectedIndex = VideoLst.Items.Count-1;

            else VideoLst.SelectedIndex -= 1;


            Play();

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            //Back To The Browser;
            //This Is Saving The Data
           

        }


        private void VideoLstbtn_Select(object sender, EventArgs e)
        {
            Program.VideoIndex = VideoLst.SelectedIndex;
            //CurrentVideo = Program.Folder.FullName + PlayList[Program.VideoIndex].ToString();

        }

        

        private void VideoLstbtn_Click(object sender, EventArgs e)
        {

            panel2.Visible = !panel2.Visible;
            //if (panel2.Width == 240)
            //    panel2.Width = 25;
            //else panel2.Width = 240;

            //VideoLst.Visible = !VideoLst.Visible;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //p.Video.Zoom(1.1);
        }

        private void VideoPlayer_DoubleClick(object sender, EventArgs e)
        {
        }

        
        private void ByCrationTimeVideoLstMenu_Click(object sender, EventArgs e)
        {

            SortMode = "Cration Time";
            SortTheList(SortMode);
            ChickSortMode(SortMode);


        }

        private void ByLenghtVideoLstMenu_Click(object sender, EventArgs e)
        {
            SortMode = "Lenght";
            SortTheList(SortMode);
            ChickSortMode(SortMode);

        }

        private void ByExtensionVideoLstMenu_Click(object sender, EventArgs e)
        {
            SortMode = "Extension";
            SortTheList(SortMode);
            ChickSortMode(SortMode);

        }

        private void ByNameVideoLstMenu_Click(object sender, EventArgs e)
        {
            SortMode = "Name";

            SortTheList(SortMode);

            ChickSortMode(SortMode);

        }
        private void SortTheList(string mode)
        {
            IComparer<FileInfo> comparer = null;
            switch (mode)
            {
                case "Name":
                    comparer = new ByName();
                    break;
                case "Cration Time":
                    comparer = new ByCreationTime();
                    break;
                case "Lenght":
                    comparer = new ByLenght();
                    break;
                case "Extension":
                    comparer = new ByExtension();
                    break;
               
                

            }
            if (comparer == null)
                PlayList.Reverse();
            else PlayList.Sort(comparer);

            SetVideoLst();
        }

        private void ReverseVideoLstMenu_Click(object sender, EventArgs e)
        {
            SortMode = "Reverse";
            SortTheList(SortMode);
            ChickSortMode(SortMode);
        }

        private void RepeatVideoLstMenu_Click(object sender, EventArgs e)
        {
            PlayMode = "Repeat";
            ChickPlayMode(PlayMode);

        }

        private void RandomVideoLstMenu_Click(object sender, EventArgs e)
        {
            PlayMode = "Random";
            ChickPlayMode(PlayMode);

        }

        private void playAllOnceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayMode = "Play All";
            ChickPlayMode(PlayMode);

        }
        private void OnceVideoLstMenu_Click(object sender, EventArgs e)
        {
            PlayMode = "Once";
            ChickPlayMode(PlayMode);

        }
        private void ChickPlayMode(string Mode)
        {
            switch (Mode)
            {
                case "Once":
                    foreach(ToolStripMenuItem item in playToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    OnceVideoLstMenu.Checked = true;
                    break;
                case "Repeat":
                    foreach (ToolStripMenuItem item in playToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    RepeatVideoLstMenu.Checked = true;
                    break;
                case "Random":
                    foreach (ToolStripMenuItem item in playToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    RandomVideoLstMenu.Checked = true;
                    break;
                case "Play All":
                    foreach (ToolStripMenuItem item in playToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    playAllOnceToolStripMenuItem.Checked = true;
                    break;
            }
        }
        private void ChickScreenDisplayMode(string Mode)
        {
            switch (Mode)
            {
                case "Normal":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    NormalModeToolbtn.Checked = true;
                    break;
                case "Zoom Center":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    ZoomCenterModeToolbtn.Checked = true;
                    break;
                case "Zoom":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    ZoomModeToolbtn.Checked = true;
                    break;
                case "Zise To Fit Center":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    ZiseToFitModeToolbtn.Checked = true;
                    break;
                case "Manual":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    ManualModeToolbtn.Checked = true;
                    break;
                case "Center":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    CenterModeToolbtn.Checked = true;
                    break;
                case "Cover Center":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    CoverCenterModebtn.Checked = true;
                    break;
                case "Strectch":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    StrectchToolbtn.Checked = true;
                    break;
                case "Size To Fit":
                    foreach (ToolStripMenuItem item in ScreenMode.Items)
                    {
                        item.Checked = false;
                    }
                    ZiseToFitModeToolbtn.Checked = true;
                    break;

            }
        }
        private void ChickSortMode(string Mode)
        {
           
            switch (Mode)
            {
                case "Reverse":
                    foreach (ToolStripMenuItem item in reorderToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    ReverseVideoLstMenu.Checked = true;
                    break;
                case "Name":
                    foreach (ToolStripMenuItem item in reorderToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    ByNameVideoLstMenu.Checked = true;
                    break;
                case"Lenght":
                    foreach (ToolStripMenuItem item in reorderToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    ByLenghtVideoLstMenu.Checked = true;
                    break;
                case "Extension":
                    foreach (ToolStripMenuItem item in reorderToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    ByExtensionVideoLstMenu.Checked = true;
                    break;
                case "Cration Time":
                    foreach (ToolStripMenuItem item in reorderToolStripMenuItem.DropDownItems)
                    {
                        item.Checked = false;
                    }
                    ByCrationTimeVideoLstMenu.Checked = true;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = p.TaskbarProgress.State.ToString();

        }

        private void VolumeMam_Click(object sender, EventArgs e)
        {
            p.Audio.Volume += 0.01f;
            Volumelbl.Text = ((p.Audio.Volume) * 100).ToString().Substring(0,2);
        }

        private void VolumeMim_Click(object sender, EventArgs e)
        {
            p.Audio.Volume -= 0.01f;
            Volumelbl.Text = ((p.Audio.Volume) * 100).ToString().Substring(0,2);

        }

        private void VolumeMute_Click(object sender, EventArgs e)
        {
            p.Mute = !p.Mute;
            
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            VideoLstbtn.Visible = true;
            //Backbtn.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void VideoLstbtn_MouseHover(object sender, EventArgs e)
        {
            VideoLstbtn.Visible = true;
            //Backbtn.Visible = true;
        }

        private void VideoLstbtn_MouseLeave(object sender, EventArgs e)
        {
            VideoLstbtn.Visible = false;
            //Backbtn.Visible = false;
        }

        private void VideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save Settings That Will Be Around The Whole World
            Settings.Default.SortMode = SortMode;
            Settings.Default.PlayMode = PlayMode;
            Settings.Default.ScreenDisplayMode = ScreenDisplayMode;

        }

        private void VideoPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            p.Display.Mode = DisplayMode.Normal;
            ScreenDisplayMode = "Normal";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void zoomCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.ZoomCenter;
            ScreenDisplayMode = "Zoom Center";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.Zoom;
            ScreenDisplayMode = "Zoom";
            ChickScreenDisplayMode(ScreenDisplayMode);
        }

        private void sizeToFitCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.SizeToFitCenter;
            ScreenDisplayMode = "Zise To Fit Center";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void sizeToFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.SizeToFit;
            ScreenDisplayMode = "Size To Fit";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.Manual;
            ScreenDisplayMode = "Manual";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.Center;

            ScreenDisplayMode = "Center";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void coverCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.CoverCenter;
            ScreenDisplayMode = "Cover Center";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void strectchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Display.Mode = DisplayMode.Stretch;

            ScreenDisplayMode = "Stretch";
            ChickScreenDisplayMode(ScreenDisplayMode);

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            float scrolvalue=trackBar2.Value / 100f;
            p.Audio.Volume = scrolvalue;
            Volumelbl.Text = trackBar2.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Screenpnl_Click(object sender, EventArgs e)
        {
           foreach(Control c in VideoControlpnl.Controls)
            {
                c.Visible = !c.Visible;
                //trackBar3.Visible = !trackBar3.Visible;
                //Stalbl.Visible = !Stalbl.Visible;
                //Endlbl.Visible = !Endlbl.Visible;
            }
            
        }

        private void Screenpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Settings.Default.SortMode = SortMode;
            Settings.Default.PlayMode = PlayMode;
            Settings.Default.ScreenDisplayMode = ScreenDisplayMode;
            p.Dispose();
            foreach (Control c in Application.OpenForms[0].Controls)
                c.Show();

            Application.OpenForms[0].Show();
            Close();
        }
    }
}