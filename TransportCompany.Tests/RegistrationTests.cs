using System;
using System.Text;
using System.Collections.Generic;
using CourseWork;
using TransportCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransportCompany.Tests
{
    [TestClass]
    public class RegistrationTests
    {

        [TestMethod]
        public void CheckEmptyFields_GoodExt_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckEmptyFields("qwerty", "123456", "123456");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckEmptyFields_GoodExt_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckEmptyFields("", "", "");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckLenghtLogin_GoodExt_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckLenghtLogin("qwerty");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckLenghtLogin_GoodExt_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckLenghtLogin("qwe");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckLenghtPassword_GoodExt_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckLenghtPassword("1234");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckLenghtPassword_GoodExt_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckLenghtPassword("123456");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPasswordMatch_GoodExt_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckPasswordMatch("123456","1234567");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPasswordMatch_GoodExt_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool result = DataValidation.CheckPasswordMatch("123456","123456");
            Assert.IsTrue(result);
        }
    }
}
