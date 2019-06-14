using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest1.Models;

namespace UnitTest1.Test.Test
{
    [TestFixture]
    class UserTest : UnitTestBase
    {
        private Mock<IUser> _myInterfaceMock;
        private readonly string fullName = "Truong Anh";

        [SetUp]
        public void Setup()
        {
            _myInterfaceMock = mockRepository.Create<IUser>();
        }

        private IUser GetUserMock()
        {
            _myInterfaceMock.Setup(x => x.GetFullName()).Returns("Truong Anh");
            return _myInterfaceMock.Object;
        }

        [Test]
        public void FullNameEqualsTruongAnh()
        {
            IUser user = GetUserMock();
            //Assert.AreEqual(null, user);
            Assert.AreEqual(fullName, user.GetFullName());
        }

    }
}
