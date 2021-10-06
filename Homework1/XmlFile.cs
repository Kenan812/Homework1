using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework1
{
    class XmlFile : IFileService
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));

        public string Load(string filename)
        {
            string text;

            using (var ser = new StreamReader(filename))
            {
                text = (string)xmlSerializer.Deserialize(ser);
            }
                
            return text;
        }


        public void Save(string filename, string text)
        {
            using (var ser = new StreamWriter(filename))
            {
                xmlSerializer.Serialize(ser, text);
            }
        }
    }
}
