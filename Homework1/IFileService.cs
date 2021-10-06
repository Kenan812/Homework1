using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    interface IFileService
    {
        void Save(string filename, string texts);

        string Load(string filename);
    }
}
