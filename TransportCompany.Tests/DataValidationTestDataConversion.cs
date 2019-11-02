using System;
using CourseWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransportCompany.Tests
{
    [TestClass]
    public class DataValidationTestDataConversion
    {
        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght6_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdef";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght25_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmnopqrstuvwxy";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght9_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghi";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght14_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmn";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght5_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcde";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght26_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmnopqrstuvwxyz";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght2_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "ab";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtPasswordTest_StringLenght35_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmnopqrstuvwxyzaylhecotl";

            factResult = dataValidation.CheckLenghtPassword(s1);
            Assert.IsFalse(factResult);
        }

        //******************************************************************

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght4_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcd";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght25_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmnopqrstuvwxy";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght6_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdef";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght14_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmn";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght3_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abc";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght26_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmnopqrstuvwxyz";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght1_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "a";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckLenghtLoginTest_StringLenght35_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            string s1 = "abcdefghijklmnopqrstuvwxyzaylhecotl";

            factResult = dataValidation.CheckLenghtLogin(s1);
            Assert.IsFalse(factResult);
        }

        //******************************************************************

        [TestMethod]
        public void CheckCostTest_LimitNumber1_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 1;

            factResult = dataValidation.CheckCost(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckCostTest_LimitNumber10000_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 10000;

            factResult = dataValidation.CheckCost(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckCostTest_EquivalentNumber150_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 150;

            factResult = dataValidation.CheckCost(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckCostTest_EquivalentNumber9589_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 9589;

            factResult = dataValidation.CheckCost(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckCostTest_LimitNumber0_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 0;

            factResult = dataValidation.CheckCost(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckCostTest_LimitNumber10001_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 10001;

            factResult = dataValidation.CheckCost(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckCostTest_EquivalentNegativeNumber150_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = -150;

            factResult = dataValidation.CheckCost(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckCostTest_EquivalentNumber18599_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 18599;

            factResult = dataValidation.CheckCost(number);
            Assert.IsFalse(factResult);
        }

        //***********************************************

        [TestMethod]
        public void CheckWeightTest_LimitNumber1_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 1;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckWeightTest_LimitNumber38_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 38;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckWeightTest_EquivalentNumber7_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 7;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckWeightTest_EquivalentNumber32_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 32;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckWeightTest_LimitNumber0_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 0;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckWeightTest_LimitNumber39_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 39;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckWeightTest_EquivalentNegativeNumber10_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = -10;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckWeightTest_EquivalentNumber59_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 59;

            factResult = dataValidation.CheckWeight(number);
            Assert.IsFalse(factResult);
        }

        //********************************************************************

        [TestMethod]
        public void CheckVolumeTest_LimitNumber1_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 1;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckVolumeTest_LimitNumber120_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 120;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckVolumeTest_EquivalentNumber35_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 35;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckVolumeTest_EquivalentNumber112_ReturnTrue()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 112;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckVolumeTest_LimitNumber0_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 0;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckVolumeTest_LimitNumber121_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 121;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckVolumeTest_EquivalentNegativeNumber35_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = -35;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void CheckVolumeTest_EquivalentNumber193_ReturnFalse()
        {
            DataValidation dataValidation = new DataValidation();
            bool factResult;
            int number = 193;

            factResult = dataValidation.CheckVolume(number);
            Assert.IsFalse(factResult);
        }
    }
}
