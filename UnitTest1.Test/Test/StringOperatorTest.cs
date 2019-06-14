using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest1.Models;

namespace UnitTest1.Test.Test
{

    [TestFixture]
    class StringOperatorTest
    {
        //public MockRepository _mockRepository { get; private set; }
        private StringOperator _operator;

        [SetUp]
        public void Setup()
        {
            _operator = new StringOperator();
            //_mockRepository = new MockRepository(MockBehavior.Strict) { DefaultValue = DefaultValue.Empty };
        }     

        [Test]
        public void FirstConCateLastEqualsFirstLast()
        {
            var first = "First";
            var last = "Last";
            Assert.AreEqual(first + last, _operator.Concate(first , last), "Test Failed");
        }

        [Test]
        public void FirstLastStartWithFirst()
        {
            var firstLast = "FirstLast";
            var first = "First";
            Assert.IsTrue(_operator.StartWith(first, firstLast));
        }

    }
}
