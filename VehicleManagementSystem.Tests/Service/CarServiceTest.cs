using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Repository;
using VehicleManagementSystem.Service;

namespace VehicleManagementSystem.Tests.Service
{
    [TestClass]
   public class CarServiceTest
    {
        Mock<IRepository<Car>> repository = new Mock<IRepository<Car>>();
        CarService service = null;

        [TestInitialize]
        public void IntializeData()
        {
            service = new CarService(repository.Object);
        }
        [TestMethod]
        public void GetDataById()
        {
            repository.Setup(m => m.GetDataById(It.IsAny<int>())).Returns(CreateCar(2, "audi", 2, "coupe", "2.2"));
            var result = service.GetDateById(2);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Make == "audi");        
        }

        [TestMethod]
        public void GetData()
        {
            var CarList = new List<Car>();
            CarList.Add(CreateCar(1, "Toyato", 2, "coupe", "2.2"));
            CarList.Add(CreateCar(2, "Audi", 2, "coupe", "2.2"));
            repository.Setup(m => m.Get()).Returns(CarList);

            var result = service.GetData();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
            
        }        

        private Car CreateCar(int id, string make, int doors, string bodytype, string engine)
        {
            Car car = new Car();
            car.Id = id;
            car.Make = make;
            car.NoOfDoors = doors;
            car.BodyType = bodytype;
            car.Engine = engine;
            return car;
        }
    }
}
