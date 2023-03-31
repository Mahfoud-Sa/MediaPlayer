using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace MediaPlayer_0
{
    public class ByName : IComparer<FileInfo>
    {
        //This Class Is For Implementation The Sort OF File Info
        public int Compare(FileInfo x, FileInfo y)
        {
            return x.Name.CompareTo(y.Name);

        }
    }

    public class ByLenght : IComparer<FileInfo>
    {

        //This Class Is For Implementation The Sort OF File Info
        public int Compare(FileInfo x, FileInfo y)
        {
            return x.Length.CompareTo(y.Length);


        }
    }

    public class ByExtension : IComparer<FileInfo>
    {

        //This Class Is For Implementation The Sort OF File Info
        public int Compare(FileInfo x, FileInfo y)
        {
            return x.Extension.CompareTo(y.Extension);


        }
    }

    public class ByCreationTime : IComparer<FileInfo>
    {

        //This Class Is For Implementation The Sort OF File Info
        public int Compare(FileInfo x, FileInfo y)
        {
            return x.CreationTime.CompareTo(y.CreationTime);


        }
    }

    public class SortDevenition : System.Collections.IComparer
    {
        //This Class Is For Implementation The Sort OF File Info
        //SortOrder mode;
        bool ascending;
        string mode;

        public bool Ascending
        {
            set { ascending = value; }
            get { return ascending; }
        }
        public string Mode
        {
            set { mode = value; }
            get { return mode; }
        }
        public int Compare(object x, object y)
        {
            int CompaierResult;
            ListViewItem listViewX = (ListViewItem)x;
            ListViewItem listViewY = (ListViewItem)y;
            switch (Mode)
            {
                case "Name":
                case "0":
                    CompaierResult = listViewX.Text.CompareTo(listViewY.Text);
                    break;
                case "Path"://this is for the folders

                    CompaierResult = listViewX.SubItems[1].Text.CompareTo(listViewY.SubItems[1].Text);
                    break;

                case "Size"://this for the files
                    string tempX = listViewX.SubItems[1].Text.Substring(0, listViewX.SubItems[1].Text.Length - 5);
                    string tempY = listViewY.SubItems[1].Text.Substring(0, listViewY.SubItems[1].Text.Length - 5);
                    if (Convert.ToInt64(tempX) > Convert.ToInt64(tempY))
                        CompaierResult = -1;
                    else if (Convert.ToInt64(tempX) < Convert.ToInt64(tempY))
                        CompaierResult = 1;
                    else
                        CompaierResult = 0;
                    break;
                case "Extenchion"://this is for the files
                    CompaierResult = listViewX.SubItems[1].Text.CompareTo(listViewY.SubItems[1].Text);
                    break;
                case "DateModifey"://this is for the Folders and Files
                case "2":
                //case "3":
                    CompaierResult = listViewX.SubItems[1].Text.CompareTo(listViewY.SubItems[1].Text);
                    break;
                default:
                    CompaierResult = 0;
                    break;
            }
            if (!Ascending & CompaierResult != 0)
                CompaierResult = -CompaierResult;

            return CompaierResult;



        }


    }



}

