using Delimon.Win32.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdController1._0
{
    public class CmdDeleteController
    {
        /**
 * this method is using an external library file for handling PathTooLongExeptions
 * the external library is named Delimon.Win32:IO and has the same properties as Sytem.IO exept that it
 * can handle file and folder names above 260 carecters.
 */
        public static void DeleteDirectory(string path)
        {
            if (Delimon.Win32.IO.Directory.Exists(path))//if the path exists
            {
                //Delete all files from the Directory
                foreach (string file in Delimon.Win32.IO.Directory.GetFiles(path)) // loop to go thrue all files in the given path
                {
                    Delimon.Win32.IO.File.Delete(file);//deletes the file it is curently at
                }
                //Delete all child Directories
                foreach (string directory in Delimon.Win32.IO.Directory.GetDirectories(path))//loop to go thrue all folders in the given path
                {
                    DeleteDirectory(directory);//deletes the folder it is currently at
                }
                //Delete a Directory
                Delimon.Win32.IO.Directory.Delete(path); // delete root folder

            }

        }

        public static void deleteFile(String path)//delete for single file taking in the path as parameter
        {
            if (File.Exists(path))//if the path is there
            {
                File.Delete(path);//delete the path file
            }
        }
    }
}
