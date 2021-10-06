using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class XmlToJsonAdapter : XmlFile
    {
        private string _filename;

        public XmlToJsonAdapter(string filename)
        {
            _filename = filename;
        }

        public void Convert()
        {
            XmlFile xmlFile = new XmlFile();

            JsonFile jsonFile = new JsonFile();

            jsonFile.Save(_filename, xmlFile.Load(_filename));
        }

    }
}
