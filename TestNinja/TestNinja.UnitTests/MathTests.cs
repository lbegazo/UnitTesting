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
    public class MathTests
    {
        private Fundamentals.Math math;

        [SetUp]
        public void SetUp()
        {
            math = new Fundamentals.Math();
        }

        [Test]
        [TestCase(3, 4, 4)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedresult)
        {
            var result = math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedresult));
        }

        [Test]
        [Ignore("This is a ignore test")]
        public void Add_WhenCalled_ReturnTheSumaOfArguments()
        {
            //Arrange
            //var math = new TestNinja.Fundamentals.Math();
            //Act
            var result = math.Add(2, 1);
            //Assert        
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [Ignore("This is a ignore test, why?")]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = math.Max(13, 1);
            Assert.That(result, Is.EqualTo(13));
        }

        [Test]
        [Ignore("Please give me a chance")]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = math.Max(1, 3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = math.Max(3, 3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = math.GetOddNumbers(5);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Is.Unique); //No duplicates
            //Assert.That(result, Is.Ordered); //it's ordered
        }
    }
}
