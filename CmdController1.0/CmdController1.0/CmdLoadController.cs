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
        private static string tbFilePath;
        private static string tbRootPath;
        private static string tbDestPath;

        public static void loadNewFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                userSelectedPath = fileDialog.FileName;
            }
        }

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

        public static void loadNewFolder()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                userSelectedPath = folderDialog.SelectedPath;
            }
        }
    }
}
