using System;
using CourseWork;
using CourseWork.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransportCompany.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void CheckCargoInDBTest_ExistingCargo_ReturnTrue()
        {
            bool factResult;
            Cargo newCargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = 683,
                Weight = 5,
                Volume = 25,
                UploadDate = DateTime.Parse("30.12.2019"),
                TrailerType = "Крытый",
                Status = "Не доставлен",
                DownloadLocation = "Минск",
                PlaceOfDischarge = "Несвиж",
                Distance = 130
            };

            factResult = CargosDB.CheckCargoInDB(newCargo);
            Assert.IsTrue(factResult);
        }

        [TestMethod]
        public void CheckCargoInDBTest_NotExistingCargo_ReturnFalse()
        {
            bool factResult;
            Cargo newCargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = 100,
                Weight = 5,
                Volume = 2,
                UploadDate = DateTime.Parse("30.12.2019"),
                TrailerType = "Крытый",
                Status = "Не доставлен",
                DownloadLocation = "Минск",
                PlaceOfDischarge = "Жодино",
                Distance = 100
            };

            factResult = CargosDB.CheckCargoInDB(newCargo);
            Assert.IsFalse(factResult);
        }

        [TestMethod]
        public void EditCargoTest_CorrectData_ReturnTrue()
        {
            bool factResult;
            int idCargo = 9;
            Cargo cargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = 683,
                Weight = 5,
                Volume = 25,
                UploadDate = DateTime.Parse("30.12.2019"),
                TrailerType = "Крытый",
                Status = "Не доставлен",
                DownloadLocation = "Минск",
                PlaceOfDischarge = "Несвиж",
                Distance = 130
            };

            factResult = CargosDB.EditCargo(idCargo,cargo);
            Assert.IsTrue(factResult, "Проверьте введенные данные");
        }

        [TestMethod]
        public void EditCargoTest_IncorrectData_ReturnFalse()
        {
            bool factResult;
            int idCargo = 9;
            Cargo cargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = -683,
                Weight = 5,
                Volume = 0,
                UploadDate = DateTime.Parse("30.12.2018"),
                TrailerType = "Крытый",
                Status = "Не доставлен",
                DownloadLocation = "",
                PlaceOfDischarge = "Несвиж",
                Distance = 0
            };

            factResult = CargosDB.EditCargo(idCargo, cargo);
            Assert.IsFalse(factResult, "Проверьте введенные данные");
        }

        [TestMethod]
        public void DeleteCargoTest_CorrectId_ReturnTrue()
        {
            bool factResult;
            int id = 10;

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

        [TestMethod]
        public void AddCargoTest_CorrectData_ReturnTrue()
        {
            bool factResult;
            Cargo cargo = new Cargo
            {
                Name = "Чипсы",
                Cost = 1900,
                Weight = 4,
                Volume = 86,
                UploadDate = DateTime.Parse("20.12.2019"),
                TrailerType = "Крытый",
                Status = "Не доставлен",
                DownloadLocation = "Брест",
                PlaceOfDischarge = "Витебск",
                Distance = 630
            };
            
            factResult = CargosDB.AddCargo(cargo);
            Assert.IsTrue(factResult,"Проверьте введенные данные");
        }

        [TestMethod]
        public void AddCargoTest_IncorrectData_ReturnFalse()
        {
            bool factResult;
            Cargo cargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = 1900,
                Weight = -4,
                Volume = -20,
                UploadDate = DateTime.Parse("25.12.2019"),
                TrailerType = "Крытый",
                Status = "В пути",
                DownloadLocation = "Минск",
                PlaceOfDischarge = "Витебск",
                Distance = 0
            };

            factResult = CargosDB.AddCargo(cargo);
            Assert.IsFalse(factResult, "Проверьте введенные данные");
        }

        [TestMethod]
        public void AddCargoTest2_IncorrectDate_ReturnFalse()
        {
            bool factResult;
            Cargo cargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = 1900,
                Weight = 4,
                Volume = 20,
                UploadDate = DateTime.Parse("20.11.2019"),
                TrailerType = "Крытый",
                Status = "В пути",
                DownloadLocation = "Минск",
                PlaceOfDischarge = "Витебск",
                Distance = 290
            };

            factResult = CargosDB.AddCargo(cargo);
            Assert.IsFalse(factResult, "Проверьте введенную дату");
        }

        [TestMethod]
        public void AddCargoTest3_IncorrectDate_ReturnFalse()
        {
            bool factResult;
            Cargo cargo = new Cargo
            {
                Name = "Минеральная вода",
                Cost = 1900,
                Weight = 4,
                Volume = 20,
                UploadDate = DateTime.Parse("20.12.2018"),
                TrailerType = "Крытый",
                Status = "В пути",
                DownloadLocation = "Минск",
                PlaceOfDischarge = "Витебск",
                Distance = 290
            };

            factResult = CargosDB.AddCargo(cargo);
            Assert.IsFalse(factResult, "Проверьте введенную дату");
        }
    }
}
