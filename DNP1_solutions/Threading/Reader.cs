using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading

{
    public class Reader
    {
        string fileName;
        public string data;

        public Reader(string fn) { fileName = fn; }

        public void Read()
        {
            Console.WriteLine("reading {0}", fileName);
            FileStream s = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(s);
            data = r.ReadToEnd();
            Console.WriteLine("finished {0}", fileName);
            r.Close();
            s.Close();
        }

        public async Task<string> ReadAllLinesAsync()
        {
            // var lines = new List<string>();
            Console.WriteLine("ASYNC reading {0}", fileName);

            using (var reader = new StreamReader(fileName))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    data += line;
                }
            }

            Console.WriteLine("ASYNC ending{0}", fileName);

            return data;
        }
    }
}
