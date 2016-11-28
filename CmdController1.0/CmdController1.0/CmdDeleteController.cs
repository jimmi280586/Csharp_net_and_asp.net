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
 * can handle file and folder names abowe 260 carecters.
 */
        public static void DeleteDirectory(string path)
        {
            if (Delimon.Win32.IO.Directory.Exists(path))
            {
                //Delete all files from the Directory
                foreach (string file in Delimon.Win32.IO.Directory.GetFiles(path))
                {
                    Delimon.Win32.IO.File.Delete(file);
                }
                //Delete all child Directories
                foreach (string directory in Delimon.Win32.IO.Directory.GetDirectories(path))
                {
                    DeleteDirectory(directory);
                }
                //Delete a Directory
                Delimon.Win32.IO.Directory.Delete(path);

            }

        }

        public static void deleteFile(String path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
