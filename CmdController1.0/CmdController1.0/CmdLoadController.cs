using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdController1._0
{
    public class CmdLoadController
    {
        //fields
        private static string tbFilePath;
        private static string tbRootPath;
        private static string tbDestPath;

        //standard getters and setters for the fields
        public static string userSelectedPath
        {
            get { return tbFilePath; }
            set { tbFilePath = value; }
        }
        public static string rootSelectedPath
        {
            get { return tbRootPath; }
            set { tbRootPath = value; }
        }
        public static string destSelectedPath
        {
            get { return tbDestPath; }
            set { tbDestPath = value; }
        }

        public static void loadNewFile() // file loader method
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); //create new open file dialog 
            DialogResult result = fileDialog.ShowDialog();//show the file dialog
            if (result == DialogResult.OK)//if user clicks ok
            {
                userSelectedPath = fileDialog.FileName;//set the field to the filepath
            }
        }

        public static void loadNewFolder()//folder loader
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();//create new folder browser dialog
            DialogResult result = folderDialog.ShowDialog();//show the folder dialog and let user select the folder
            if (result == DialogResult.OK)//if user clicked ok
            {
                userSelectedPath = folderDialog.SelectedPath;//set field to folder path
            }
        }
    }
}
