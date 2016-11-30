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
        //async methods to make shure the program does not take over the main task for a long period of time
        public static void copyAllFilesAsync(string rootPath, string destinationPath)
        {
            Task.Run(() => copyAllFiles(rootPath, destinationPath));
        }
        public static void moveAllFilesAsync(string rootPath, string destinationPath)
        {
            Task.Run(() => moveAllFiles(rootPath, destinationPath));
        }

        //move all files from folder hiarky to specific folder at given path
        private static void moveAllFiles(String rootPath, String destinationPath)
        {
            String directoryName = destinationPath;//sets string to destination path
            DirectoryInfo directory = new DirectoryInfo(directoryName);//enitializes new directory
            if (directory.Exists == false)//if the diretory does not exist create it
                Directory.CreateDirectory(directoryName);

            // makes a list of all files in the given folder hiarky
            List<String> files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories).ToList();

            foreach (string file in files)//for all files in the list
            {
                FileInfo moveFile = new FileInfo(file);//sets movefile to the given file i the list
                //if the file does not exist in the destination folder
                // to remove name collisions be carefull if you have files with same names
                if (new FileInfo(directory + "\\" + moveFile.Name).Exists == false)
                {
                    moveFile.MoveTo(directory + "\\" + moveFile.Name);// move the file to destination
                }
            }
            AutoClosingMessageBox.Show("files were moved", "Caption", 5000);//displays messagebox for 5 seconds

        }

        private static void copyAllFiles(String rootPath, String destinationPath)
        {
            String directoryName = destinationPath;//sets string to destination path
            DirectoryInfo directory = new DirectoryInfo(directoryName);//enitializes new directory
            if (directory.Exists == false)//if the diretory does not exist create it
                Directory.CreateDirectory(directoryName);

            // makes a list of all files in the given folder hiarky
            List<String> files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories).ToList();

            foreach (string file in files)//for all files in the list
            {
                FileInfo moveFile = new FileInfo(file);//sets movefile to the given file i the list
                //if the file does not exist in the destination folder
                // to remove name collisions be carefull if you have files with same names
                if (new FileInfo(directory + "\\" + moveFile.Name).Exists == false)
                {
                    moveFile.CopyTo(directory + "\\" + moveFile.Name);// copy the file to destination
                }
            }
            //displays messagebox for 5 seconds
            AutoClosingMessageBox.Show("files were copied", "Caption", 5000);
        }

        
    }
}
