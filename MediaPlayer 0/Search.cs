using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MediaPlayer_0
{
    class Search
    {
        //Description
        //Class To Search All The Folders In  Accourder To A specific Root
        //You Can Filter The Folders That Are Empty And The Dolder That Contain a specific Files

        //fields

        private List<DirectoryInfo> Folders; //The List That Contain The FOlders

        public Search()
        {
            //Inchilizion
            Folders = new List<DirectoryInfo>();
           

        }

        
        public void SearchForFolders(DirectoryInfo Root)
        {

           // Recurigen Function That Walk Throw The Folders Three Under The Root
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            try
            {
                files = Root.GetFiles("*");


            }
            catch (Exception e)
            {
            }
            if (files != null)
            {
                subDirs = Root.GetDirectories();

                foreach (DirectoryInfo fi in subDirs)
                {
                    Folders.Add(fi);
                    //Application.OpenForms["SearchForm"].get
                    SearchForFolders(fi);

                }


            }




        }

        public int ChickFolder(DirectoryInfo folder)
        {
            //Chick If There Is a Files In specific Folder
            //Return The Number Of Files 
            int lenght = 0;

            try
            {
                foreach (FileInfo fi in folder.GetFiles())
                    foreach (string exten in Program.ext)
                        if (fi.Extension == exten)
                            lenght += 1;
            }
            catch (Exception e) { }



            return lenght;
        }

        public void DropEmptyFolders()
        {
            //Filter That Folder 
           List<DirectoryInfo> temp = new List<DirectoryInfo>();

            foreach (var file in Folders)
            {

                if (file.GetType() == typeof(DirectoryInfo) & ChickFolder(file) > 0)
                    temp.Add(file);

            }
            Folders = temp;

        }

        public void AddTo(List<DirectoryInfo> NewFolders)
        {
            //Add The Folders To The Program.Folder
            foreach(DirectoryInfo folder in Folders)
            {

                if (Program.Folders.Contains(folder))
                    continue;
                NewFolders.Add(folder);
            }
        }

        

    }
}
