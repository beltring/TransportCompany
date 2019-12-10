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

        //*********************************************
        [TestMethod]
        public void CheckLengthString3_10Test_CorrectStringLength_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string str = "asdfgh";

            factResult = dataValidation.CheckLengthString3_10(str);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLengthString3_10Test_IncorrectStringLength_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string str = "as";

            factResult = dataValidation.CheckLengthString3_10(str);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckStringForDigitsTest_StringWithDigit_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string str = "a12ssdfsdf7sdf";

            factResult = dataValidation.CheckStringForDigits(str);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckStringForDigitsTest_StringWithoutDigit_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string str = "ffffffsdjkuyyeklaa";

            factResult = dataValidation.CheckStringForDigits(str);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckAuthTest_IncorrectLogin_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string login = "abc";
            string password = "123456";

            factResult = dataValidation.CheckAuth(login,password);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckAuthTest_IncorrectPassword_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string login = "abcd";
            string password = "123";

            factResult = dataValidation.CheckAuth(login, password);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckAuthTest_CorrectData_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string login = "abcd";
            string password = "123456";

            factResult = dataValidation.CheckAuth(login, password);
            Assert.IsTrue(factResult);
        }

        //*****************************************************************
        [TestMethod]
        public void CheckDateTest_IncorrectYear_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "12.12.2018";

            factResult = dataValidation.CheckDate(date);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckDateTest_IncorrectMonth_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "25.13.2020";

            factResult = dataValidation.CheckDate(date);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckDateTest_IncorrectDay_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "35.12.2019";

            factResult = dataValidation.CheckDate(date);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckDateTest_CorrectDate_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "12.01.2020";

            factResult = dataValidation.CheckDate(date);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckDateTest_IncorrectYear1_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "25.12.2018";

            factResult = dataValidation.CheckDate(date);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckDateTest_IncorrectMonth1_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "25.13.2019";

            factResult = dataValidation.CheckDate(date);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckDateTest_IncorrectDay1_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "35.12.2019";

            factResult = dataValidation.CheckDate(date);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckDateTest_CorrectDate1_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string date = "31.12.2019";

            factResult = dataValidation.CheckDate(date);
            Assert.IsTrue(factResult);
        }
    }
}
