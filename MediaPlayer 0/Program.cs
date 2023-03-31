using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace MediaPlayer_0
{
    static class Program
    {
        public static string ChosenVideo;
        private static SqlConnection Con;//
        public static List<DirectoryInfo> Folders;//Folders That Contain PlayList;
        public static DirectoryInfo Folder;//Folder That Contain PlayList;
        public static IEnumerable<FileInfo> Files;//The Play List Itself;
        public static int VideoIndex;//The Index Of The Video In The List;
        public static string[] ext;
        public static List<DirectoryInfo> NewFolders;//Folders That Contain PlayList;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ext = new string[] { ".3g2"  , ".3gp", ".3gp2" , ".3gpp" , ".aac"  ,
                                 ".adts" , ".asf", ".avi"  , ".m2ts" , ".m4a"  , ".m4v"   , ".mkv" ,
                                 ".mov"  , ".mp3", ".mp4"  , ".mpeg" , ".mpg"  , ".mts"   , ".sami",
                                 ".smi"  , ".vob", ".wav"  , ".webm" , ".wma"  , ".wmv"};//   , ".bmp" ,".gif"  , ".ico", ".jfif" , ".jpeg" , ".jpg"  , ".png"   , ".tif" , ".tiff"  };

            Con = new SqlConnection(@"server=DESKTOP-5NPIVGS\MAHFOUD;initial catalog=PlayerDB;integrated security=true ");
            GetData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExplorForm());
            if(NewFolders.Count!=0)
            SetData();
        }

        static void SetData()
        {
            //Function To Save The Data To The DataBase
            try
            {
                
                foreach (DirectoryInfo FolderPath in NewFolders)
                {
                    
                    string Query = "insert into [Folders]  values('"+FolderPath.FullName+"')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    Con.Open();

                    cmd.ExecuteNonQuery();
                    Con.Close();

                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
           
        }

        static void GetData()
        {
            //Function To Get The Data From The DataBase

            //Inchilizion The Folders List
            Folders = new List<DirectoryInfo>();

            //Try To Get The Data From DataBase 
                try {
                    string Query = "Select [path] from [dbo].[Folders]";
                    SqlCommand cmd = new SqlCommand(Query, Con);

                    Con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            DirectoryInfo dr = new DirectoryInfo(@reader[0].ToString());
                            if(dr.Exists==true)
                            Folders.Add(dr);
                        }
                        catch (Exception e) { }
                    }

                    }
                catch (Exception e) {

                    MessageBox.Show(e.Message.ToString());

                        }
                finally
                {
                    Con.Close();

                }


            //If The Data Base Emty
                if (Folders.Count == 0)
                    {
                        //Search The DeskTop
                        Search S = new Search();
                        S.SearchForFolders(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)));
                        S.DropEmptyFolders();
                        S.AddTo(Program.Folders);
                    }

        }


    }
}
