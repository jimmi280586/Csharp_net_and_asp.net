using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Serialization;
using Serialization;

namespace TestSerialization

{
    class Program
    {
        static void Main(string[] args)
        {
          //  Save();
          //  Load();

          //  SaveSOAP();
          //LoadSOAP();

            SaveXML();
            LoadXML();

            Console.ReadKey();
        }

        private static void LoadXML()
        {
            XmlTextReader reader = new XmlTextReader(@"C:\Tmp\MyFile.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Person));


            Person obj = (Person)serializer.Deserialize(reader);

            Console.WriteLine("The Person has been read from file XML");

        }

        private static void SaveXML()
        {
            // Create a person object.
            Person per = new Person() { FirstName = "Kim", LastName = "Aabech", Ssn = 2222 };

            // Serialize the object to a file.
            using (XmlTextWriter writer = new XmlTextWriter(@"C:\Tmp\MyFile.xml", null))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(writer, per);
            }
        }

        static void Save()
        {
            Person person = new Person() { FirstName = "Kim", LastName = "Foged", Ssn = 1234 };

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Tmp\MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize( stream, person );
            stream.Close();

            Console.WriteLine("Person has been saved to file");
        }

        static void Load()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Tmp\MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read); 
            Person obj = (Person)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine( "The Person has been read from file" );

            // Here's the proof. 
            Console.WriteLine("Fullname: {0}", obj.FullName() );
            Console.WriteLine("SSN: {0}", obj.Ssn);
        }

        static void SaveSOAP()
        {
            Person per = new Person() { FirstName = "Kim", LastName = "Foged", Ssn = 1234 };


            IFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream(@"C:\Tmp\MyFileSOAP.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, per);
            stream.Close();

            Console.WriteLine("Person has been saved to file as SOAP");
        }

        static void LoadSOAP()
        {
            IFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream(@"C:\Tmp\MyFileSOAP.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person obj = (Person)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("The Person has been read from file as SOAP");

            // Here's the proof. 
            Console.WriteLine("Fullname: {0}", obj.FullName());
            Console.WriteLine("SSN: {0}", obj.Ssn);
        }
    }
}
