using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWork;
using TransportCompany;
using CourseWork.Context;

namespace TransportCompany.Tests
{
    [TestClass]
    public class CatalogContextTest
    {
        [TestMethod]
        public void AddCargoTest_CorrectData_ReturnTrue()
        {
            bool factResult;
            Cargo cargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = 1900,
                Weight = 4,
                Volume = 20,
                UploadDate = DateTime.Parse("25.12.2019"),
                TrailerType = "Крытый",
                Status = "В пути",
                DownloadLocation = "Минск",
                PlaceOfDischarge = "Витебск",
                Distance = 290
            };

            factResult = CargosDB.AddCargo(cargo);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void AddCargoTest_IncorrectData_ReturnFalse()
        {
            bool factResult;
            Cargo cargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = -50,
                Weight = 0,
                Volume = 20,
                UploadDate = DateTime.Parse("09.11.2019"),
                TrailerType = "Крытый",
                Status = "В пути",
                DownloadLocation = "",
                PlaceOfDischarge = "Витебск",
                Distance = -10
            };

            factResult = CargosDB.AddCargo(cargo);
            Assert.IsFalse(factResult);
        }

        //**************
        [TestMethod]
        public void DeleteCargoTest_CorrectId_ReturnTrue()
        {
            bool factResult;
            int id = 14;

            factResult = CargosDB.DeleteCargo(id);
            Assert.IsTrue(factResult);
        }
        [TestMethod]
        public void DeleteCargoTest_IncorrectId_ReturnFalse()
        {
            bool factResult;
            int id = 0;

            factResult = CargosDB.DeleteCargo(id);
            Assert.IsFalse(factResult);
        }
    }
}
