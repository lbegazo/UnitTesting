using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests3
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        [Ignore("Because I wanted to")]
        public void Add_WhenIsCalled_ReturnTheGreaterArgument()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Add_WhenIsCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            //var math = new Fundamentals.Math();

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
