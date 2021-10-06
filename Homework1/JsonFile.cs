using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Homework1
{
    class JsonFile : IFileService
    {
        JsonSerializer JsonSerializer = new JsonSerializer();

        public string Load(string filename)
        {
            string text;

            using (var ser = new StreamReader(filename))
            {
                text = ser.ReadToEnd();

                text = (string)JsonConvert.DeserializeObject(text);
            }

            return text;
        }

        public void Save(string filename, string text)
        {
            using (var ser = new StreamWriter(filename))
            {
                JsonSerializer.Serialize(ser, text);
            }
        }
    }
}
