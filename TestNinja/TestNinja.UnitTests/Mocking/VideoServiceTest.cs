using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTest
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            //var fileReader = new Mock<IFileReader>();
            

            var videoService = new VideoService(new FakeFileReader());           

            //videoService.FileReader = new FakeFileReader();

            var result = videoService.ReadVideoTitle();
            Assert.That(result, Does.Contain("Error").IgnoreCase);
        }

    }
}
