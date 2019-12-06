using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWork;
using TransportCompany;
using CourseWork.Context;

namespace TransportCompany.Tests
{
    [TestClass]
    public class CargosDBTest
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

        //**************
        [TestMethod]
        public void SelectByIdTest_CorrectId_ReturnCargo()
        {
            Cargo expectResult = new Cargo
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
            Cargo factResult;
            int id = 12;

            factResult = CargosDB.SelectById(id);
            Assert.ReferenceEquals(expectResult, factResult);
        }

        [TestMethod]
        public void SelectByIdTest_InCorrectId_ReturnNull()
        {
            Cargo factResult;
            int id = 33;

            factResult = CargosDB.SelectById(id);
            Assert.AreEqual(null, factResult);
        }
        
        //**************
        [TestMethod]
        public void SelectAllDetailedTest_CorrectId_ReturnDetailedInformation()
        {
            string expectResult = "Название: Чипсы \nСтоимость: 1900 \nВес: 4 \nОбъём: 86 \n" +
                            "Тип кузова: Крытый \nДата загрузки: 20.12.2019 0:00:00 \nСтатус заказа: Не доставлен \nМесто загрузки: " +
                            "Брест \nМесто разгрузки: Витебск \nРасстояние: 630\n";
            string factResult;
            int id = 12;

            factResult = CargosDB.SelectAllDetailed(id);
            Assert.AreEqual(expectResult, factResult);
        }

        [TestMethod]
        public void SelectAllDetailedTest_inCorrectId_ReturnNull()
        {
            string expectResult = "";
            string factResult;
            int id = 33;

            factResult = CargosDB.SelectAllDetailed(id);
            Assert.AreEqual(expectResult, factResult);
        }
    }
}
