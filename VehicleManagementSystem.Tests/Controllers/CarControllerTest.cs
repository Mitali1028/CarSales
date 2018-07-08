using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleManagementSystem.Models;
using Moq;
using VehicleManagementSystem.Service;
using System.Collections.Generic;

namespace VehicleManagementSystem.Tests.Controllers
{
    [TestClass]
    public class CarControllerTest
    {
        Mock<Car>  carModel = new Mock<Car>();
        Mock<IService<Car>> service = new Mock<IService<Car>>();
        CarController controller = null;

        [TestInitialize]
        public void DecalreModel()
        {
            controller = new CarController(service.Object);
            carModel.Object.Id = 1;
            carModel.Object.Make = "xxx";
            carModel.Object.Model = "yyy";
            carModel.Object.Engine = "v45";
            carModel.Object.NoOfDoors = 4;
            carModel.Object.BodyType = "Sedan";

        }
        [TestMethod]
        public void Index()
        {
            // Act                    
            var carList = new List<Car>();
            carList.Add(CreateCar(1, "Toyato", 2, "coupe", "2.2"));
            carList.Add(CreateCar(2, "Audi", 2, "coupe", "2.2"));      

            service.Setup(s => s.GetData()).Returns(carList);

            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);        
        }

        [TestMethod]
        public void Edit()
        {

            service.Setup(s => s.GetDateById(It.IsAny<int>())).Returns(CreateCar(3, "audi", 2, "coupe", "2.2"));                        
            // Act
            ViewResult result = controller.Edit(3) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);          
        }

        [TestMethod]
        public void EditPOST()
        {
            service.Setup(s => s.Update(CreateCar(3, "audi", 2, "coupe", "2.2")));
           // Act
            ViewResult result = controller.Edit(carModel.Object) as ViewResult;

            // Assert
          Assert.IsNull(result);
        }
        [TestMethod]
        public void AddCar()
        {
           
            ViewResult result = controller.AddCar(carModel.Object) as ViewResult;

           Assert.IsNull(result);

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
