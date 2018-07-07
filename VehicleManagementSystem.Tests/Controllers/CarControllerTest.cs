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
        [TestInitialize]
        public void DecalreModel()
        {   
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
            // Arrange
            var controller = new CarController();

            // Act                    
            
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Edit()
        {
            // Arrange
            CarController controller = new CarController();

            // Act
            ViewResult result = controller.Edit(3) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EditPOST()
        {       
            // Arrange
            CarController controller = new CarController();

            // Act
            ViewResult result = controller.Edit(carModel.Object) as ViewResult;

            // Assert
          //  Assert.IsNotNull(result);
        }
        [TestMethod]
        public void AddCar()
        {
            CarController controller = new CarController();

            ViewResult result = controller.AddCar(carModel.Object) as ViewResult;

          //  Assert.IsNotNull(result);

        }


        }
}
