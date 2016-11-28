using Delimon.Win32.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdController1._0
{
   public class CmdFileController
    {
        public static void copyAllFilesAsync(string rootPath, string destinationPath)
        {
            Task.Run(() => copyAllFiles(rootPath, destinationPath));
        }
        public static void moveAllFilesAsync(string rootPath, string destinationPath)
        {
            Task.Run(() => moveAllFiles(rootPath, destinationPath));
        }
        private static void moveAllFiles(String rootPath, String destinationPath)
        {
            String directoryName = destinationPath;
            DirectoryInfo dirInfo = new DirectoryInfo(directoryName);
            if (dirInfo.Exists == false)
                Directory.CreateDirectory(directoryName);

            List<String> files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories).ToList();

            foreach (string file in files)
            {
                FileInfo mFile = new FileInfo(file);
                // to remove name collisions
                if (new FileInfo(dirInfo + "\\" + mFile.Name).Exists == false)
                {
                    mFile.MoveTo(dirInfo + "\\" + mFile.Name);
                }
            }
            AutoClosingMessageBox.Show("files were moved", "Caption", 5000);

        }

        private static void copyAllFiles(String rootPath, String destinationPath)
        {
            String directoryName = destinationPath;
            DirectoryInfo dirInfo = new DirectoryInfo(directoryName);
            if (dirInfo.Exists == false)
                Directory.CreateDirectory(directoryName);

            List<String> files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories).ToList();

            foreach (string file in files)
            {
                FileInfo mFile = new FileInfo(file);
                // to remove name collisions
                if (new FileInfo(dirInfo + "\\" + mFile.Name).Exists == false)
                {
                    mFile.CopyTo(dirInfo + "\\" + mFile.Name);
                }
            }
            AutoClosingMessageBox.Show("files were copied", "Caption", 5000);
        }

        
    }
}
