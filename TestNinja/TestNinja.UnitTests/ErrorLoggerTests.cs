using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public  class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;

        [SetUp]
        public void SetUp()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _errorLogger.Log("error test");
            Assert.That(_errorLogger.LastError, Is.EqualTo("error test"));

        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [Ignore("Not call")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
        }
    }
}
