using CourseWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransportCompany.Tests
{
    [TestClass]
    public class AuthorizationTest
    {
        [TestMethod]
        public void IsAdminTest_CorrectString_ReturnTrue()
        {
            Authorization authorization = new Authorization();
            bool factResult;
            string s1 = "admin";
            string s2 = "admin99";

            factResult = authorization.IsAdmin(s1,s2);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void IsAdminTest_WrongString_ReturnFalse()
        {
            Authorization authorization = new Authorization();
            bool factResult;
            string s1 = "admin";
            string s2 = "admin123";

            factResult = authorization.IsAdmin(s1,s2);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void IsUserTest_CorrectString_ReturnTrue()
        {
            Authorization authorization = new Authorization();
            bool factResult;
            string s1 = "kess";
            string s2 = "kess99";

            factResult = authorization.IsUser(s1,s2);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void IsUserTest_WrongString_ReturnFalse()
        {
            Authorization authorization = new Authorization();
            bool factResult;
            string s1 = "";
            string s2 = "";

            factResult = authorization.IsUser(s1,s2);
            Assert.IsFalse(factResult);
        }
    }
}
