using System;
using CourseWork.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransportCompany.Tests
{
    [TestClass]
    public class UsersDBTest
    {
        [TestMethod]
        public void IsAdminTest_CorrectString_ReturnTrue()
        {
            bool factResult;
            string s1 = "admin";
            string s2 = "admin99";

            factResult = UsersDB.IsAdmin(s1, s2);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void IsAdminTest_WrongString_ReturnFalse()
        {
            bool factResult;
            string s1 = "admin";
            string s2 = "admin123";

            factResult = UsersDB.IsAdmin(s1, s2);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void IsUserTest_CorrectString_ReturnTrue()
        {
            bool factResult;
            string s1 = "kess";
            string s2 = "kess99";

            factResult = UsersDB.IsUser(s1, s2);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void IsUserTest_WrongString_ReturnFalse()
        {
            bool factResult;
            string s1 = "abcd";
            string s2 = "123456";

            factResult = UsersDB.IsUser(s1, s2);
            Assert.IsFalse(factResult);
        }
        

        [TestMethod]
        public void SelectCargoIdTest_CorrectLogin_Return7_4()
        {
            string factResult;
            string expectResult = " 7 4";

            factResult = UsersDB.SelectCargoId("minsk");
            Assert.AreEqual(expectResult, factResult);
        }

        [TestMethod]
        public void SelectCargoIdTest_IncorrectLogin_ReturnNull()
        {
            string factResult;
            string expectResult = null;

            factResult = UsersDB.SelectCargoId("sdfdfgfg");
            Assert.AreEqual(expectResult, factResult);
        }

        [TestMethod]
        public void CheckUserInDBTest_CorrectLogin_ReturnTrue()
        {
            bool factResult;

            factResult = UsersDB.CheckUserInDB("kess");
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckUserInDBTest_IncorrectLogin_ReturnFalse()
        {
            bool factResult;

            factResult = UsersDB.CheckUserInDB("dfgdbvdfb");
            Assert.IsFalse(factResult);
        }
    }
}
