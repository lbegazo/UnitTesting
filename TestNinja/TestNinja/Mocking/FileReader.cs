using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class FileReader : IFileReader
    {
        public IFileReader Object => throw new NotImplementedException();

        public string Read(string path)
        {
            return File.ReadAllText("video.txt");
        }
    }
}
