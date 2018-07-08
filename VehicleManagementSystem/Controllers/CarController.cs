using System;
using System.Linq;
using System.Web.Mvc;
using VehicleManagementSystem.Repository;
using VehicleManagementSystem.Service;

namespace VehicleManagementSystem.Models
{
    public class CarController : Controller
    {
        private IService<Car> _carService;

        public CarController()
        {
          _carService = new CarService();
        }
        public CarController(IService<Car> carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public ActionResult AddCar()
        {
            return View();
        }
        // GET: Car
        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            _carService.Add(car);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Index()
        {
            try {
                var model = _carService.GetData();
                return View(model);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _carService.GetDateById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Car carmodel)
        {
            if (ModelState.IsValid)
            {
                _carService.Update(carmodel);
                return RedirectToAction("Index");
            }
            return View(carmodel);
        }

    }



}