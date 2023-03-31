using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MediaPlayer_0
{
    public partial class SearchForm : Form
    {
        List<DriveInfo> ComputerDrivers;//The Drivers In The Computer
        public SearchForm()
        {
            
            ComputerDrivers = new List<DriveInfo>();
            InitializeComponent();

        }

        private void GetDrivers()
        {
            string[] NameOfDrivers= Environment.GetLogicalDrives();
            foreach(string Drive in NameOfDrivers)
            {
                ComputerDrivers.Add(new DriveInfo(Drive));
            } 
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;

            GetDrivers();
            int x = 20;
            foreach (DriveInfo Dr in ComputerDrivers)
            {
                CheckBox chickbox = new CheckBox();

                chickbox.AutoSize = true;
                chickbox.Name = "Drive "+Dr.Name[0];
                chickbox.Size = new System.Drawing.Size(77, 17);
                chickbox.TabIndex = 6;
                chickbox.Text = Dr.Name;
                chickbox.UseVisualStyleBackColor = true;
                chickbox.Location= new System.Drawing.Point(6, x);
                x += 20;
                if (Dr.IsReady == false)chickbox.Enabled = false;

                    groupBox1.Controls.Add(chickbox);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            LoadingFolders.RunWorkerAsync();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            LoadingFolders.CancelAsync();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingFolders_DoWork(object sender, DoWorkEventArgs e)
        {
            UseWaitCursor = true;
            foreach (CheckBox Cbox in groupBox1.Controls)
            {
                
                if (Cbox.CheckState != CheckState.Checked)
                    continue;
                Search s = new Search();

                s.SearchForFolders(new DirectoryInfo(Cbox.Text));

                
                s.DropEmptyFolders();
                Invoke(new Action(()=>
                    {
                        
                        s.AddTo(Program.NewFolders);

                    }
                    ));

            }
            UseWaitCursor = false;


        }


        private void LoadingFolders_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done");
            Close();
        }

        
    }
}
