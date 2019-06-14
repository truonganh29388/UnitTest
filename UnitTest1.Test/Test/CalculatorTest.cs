using NUnit.Framework;
using UnitTest1.Models;

namespace UnitTest1.Test.Test
{
    [TestFixture]
    class CalculatorTest
    {
        private Calculator _cal;

        [SetUp]
        public void Setup()
        {
            _cal = new Calculator();
        }

        [Test]
        public void OnePlusOneEqualsTwo()
        {
            Assert.AreEqual(2, _cal.Add(1, 1));
        }

        [Test]
        public void FivePlusFiveEqualsTen()
        {
            Assert.AreEqual(10, _cal.Add(5, 5));
        }

        [Test]
        public void HundredSubstractTenEqualsNineTy()
        {
            Assert.AreEqual(90, _cal.Subtract(100, 10));
        }
   
    }
}
