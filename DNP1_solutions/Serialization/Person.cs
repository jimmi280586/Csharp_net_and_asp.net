using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization

{
    [Serializable] 
    public class Person : IXmlSerializable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }

        public string FullName( )
        {
            return FirstName + " " + LastName;
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return (null);
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            reader.ReadToFollowing("FirstName");
            FirstName = reader.ReadElementContentAsString("FirstName", "");
            LastName = reader.ReadElementContentAsString("LastName", "");

            string s = reader.ReadElementContentAsString("Ssn", "");
            Ssn = int.Parse(s);
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("FirstName", FirstName);
            writer.WriteElementString("LastName", LastName);
            writer.WriteElementString("Ssn", Ssn.ToString());
        }


    }
}
