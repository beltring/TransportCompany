using System;
using CourseWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransportCompany.Tests
{
    [TestClass]
    public class AuthorizationTests
    {
        [TestMethod]
        public void IsAdminTest_GoodExt_ReturnTrue()
        {
            Authorization authorization = new Authorization();
            bool result = authorization.IsAdmin("admin", "admin99");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAdminTest_BadExt_ReturnFalse()
        {
            Authorization authorization = new Authorization();
            bool result = authorization.IsAdmin("admin", "admin123");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsUserTest_GoodExt_ReturnTrue()
        {
            Authorization authorization = new Authorization();
            bool result = authorization.IsUser("kess", "kess99");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUserTest_BadExt_ReturnFalse()
        {
            Authorization authorization = new Authorization();
            bool result = authorization.IsUser("", "");
            Assert.IsFalse(result);
        }
    }
}
