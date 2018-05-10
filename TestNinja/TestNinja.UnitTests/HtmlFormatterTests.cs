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
    public class HtmlFormatterTests
    {
        private HtmlFormatter _htmlFormatter;

        [SetUp]
        public void SetUp()
        {
            _htmlFormatter = new HtmlFormatter();
        }

        [Test]
        public void FormatAsBold_WhenIsCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var result = _htmlFormatter.FormatAsBold("hola");
            //Specific
            Assert.That(result, Is.EqualTo("<strong>HOLA</strong>").IgnoreCase);

            //General
            //Assert.That(result, Does.StartWith("<strong>"));
            //Assert.That(result, Does.Contain("hola"));
            //Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}
