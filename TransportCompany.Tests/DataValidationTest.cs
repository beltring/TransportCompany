using System;
using System.Text;
using System.Collections.Generic;
using CourseWork;
using TransportCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransportCompany.Tests
{
    [TestClass]
    public class DataValidationTest
    {

        [TestMethod]
        public void CheckEmptyFieldsTest_CorrectString_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "qwerty";
            string s2 = "123456";
            string s3 = "123456";

            factResult = dataValidation.CheckEmptyFields(s1,s2,s3);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckEmptyFieldsTest_WrongString_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "";
            string s2 = "";
            string s3 = "";

            factResult = dataValidation.CheckEmptyFields(s1,s2,s3);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_CorrectString_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "qwerty";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_WrongString_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "qwe";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_WrongString_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "1234";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_CorrectString_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "123456";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckPasswordMatchTest_WrongString_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "123456";
            string s2 = "1234567";

            factResult = dataValidation.CheckPasswordMatch(s1,s2);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckPasswordMatchTest_CorrectString_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "123456";
            string s2 = "123456";

            factResult = dataValidation.CheckPasswordMatch(s1,s2);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckNegativeNumberTest_PositiveNumber_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 5;

            factResult = dataValidation.CheckNegativeNumber(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckNegativeNumberTest_NegativeNumber_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = -15;

            factResult = dataValidation.CheckNegativeNumber(number);
            Assert.IsFalse(factResult);
        }
    }
}
