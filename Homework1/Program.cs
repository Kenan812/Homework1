using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";
            XmlFile xmlFile = new XmlFile();
            xmlFile.Save("file", text);


            //XmlToJsonAdapter xmlToJsonAdapter = new XmlToJsonAdapter("file");
            //xmlToJsonAdapter.Convert();




        }
    }
}
