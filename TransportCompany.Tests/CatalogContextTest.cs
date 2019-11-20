using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWork;
using TransportCompany;

namespace TransportCompany.Tests
{
    [TestClass]
    public class CatalogContextTest
    {
        [TestMethod]
        public void AddCargoTest_CorrectData_ReturnTrue()
        {
            bool factResult;
            Cargo cargo = new Cargo("Минеральная воа", 1900, 4, 20, "09.11.2019", "Крытый", "В пути", "Минск", "Витебск", 350);

            factResult = CatalogContext.AddCargo(cargo);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void AddCargoTest_IncorrectData_ReturnFalse()
        {
            bool factResult;
            Cargo cargo = new Cargo("Минеральная вода", -50, 0, 20, "", "Крытый", "В пути", "", "Гомель", -10);

            factResult = CatalogContext.AddCargo(cargo);
            Assert.IsFalse(factResult);
        }

        //**************
        [TestMethod]
        public void DeleteCargoTest_CorrectId_ReturnTrue()
        {
            bool factResult;
            int id = 14;

            factResult = CatalogContext.DeleteCargo(id);
            Assert.IsTrue(factResult);
        }
        [TestMethod]
        public void DeleteCargoTest_IncorrectId_ReturnFalse()
        {
            bool factResult;
            int id = 0;

            factResult = CatalogContext.DeleteCargo(id);
            Assert.IsFalse(factResult);
        }
    }
}
