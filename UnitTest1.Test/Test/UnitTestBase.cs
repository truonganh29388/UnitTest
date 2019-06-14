using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest1.Test.Test
{
    class UnitTestBase
    {
        public MockRepository mockRepository { get; private set; }

        [SetUp]
        public void UnitTestBaseSetUp()
        {
            mockRepository = new MockRepository(MockBehavior.Strict) { DefaultValue = DefaultValue.Empty };
        }

        [TearDown]
        public void VerifyAndTearDown()
        {
            mockRepository.VerifyAll();
        }
    }
}
