﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    public class FakeFileReader : IFileReader
    {
        public IFileReader Object => throw new NotImplementedException();

        public string Read(string path)
        {
            return "";
        }
    }
}
