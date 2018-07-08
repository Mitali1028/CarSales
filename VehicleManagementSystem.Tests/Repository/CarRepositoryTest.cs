using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Repository;

namespace VehicleManagementSystem.Tests.Repository
{
    [TestClass]
    public class CarRepositoryTest
    {
        Mock<Car> carModel = new Mock<Car>();
        [TestInitialize]
        public void IntializeData()
        {
            carModel.Object.Id = 4;
            carModel.Object.Make = "xxx";
            carModel.Object.Model = "yyy";
            carModel.Object.Engine = "v45";
            carModel.Object.NoOfDoors = 4;
            carModel.Object.BodyType = "Sedan";
        }

        [TestMethod]
        public void GetDataById()
        {
            var repository = new CarRepository();

            var result = repository.GetDataById(2);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Make, "Audi");
        }

        [TestMethod]
        public void GetDataByIdNegativeTest()
        {
            var repository = new CarRepository();

            var result = repository.GetDataById(0);

            Assert.IsNull(result);

        }

        [TestMethod]
        public void GetData()
        {
            var repository = new CarRepository();

            var result = repository.Get();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }
        [TestMethod]
        public void AddCar()
        {
            var repository = new CarRepository();

            int id = repository.Add(carModel.Object);

            Assert.AreEqual(id, 4);
                       
        }


    }
}
