using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest1.Models;

namespace UnitTest1.Test.Test
{
    [TestFixture]
    class PrimeServiceTest:UnitTestBase
    {
        private PrimeService _primeService;
        private Mock<User> _myInterfaceMock;

        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            Assert.IsFalse(_primeService.IsPrime(value), $"{value} should not be prime");
        }

    }
}
