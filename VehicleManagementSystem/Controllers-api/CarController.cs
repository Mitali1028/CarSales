using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Service;

namespace VehicleManagementSystem.Controllers_api
{
    public class CarController : ApiController
    {
        private IService<Car> _carService;

        public CarController()
        {
            _carService = new CarService();
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            IHttpActionResult ret = null;
            var carData = _carService.GetData();
            if(carData.Count > 0)
            {
                ret = Ok(carData);
            }
            else
            {
                return NotFound();
            }

            return ret;
           
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult ret = null;
            var carData = _carService.GetDateById(id);
            if (carData != null)
            {
                ret = Ok(carData);
            }
            else
            {
                return NotFound();
            }

            return ret;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, Car car)
        {
            IHttpActionResult ret = null;
            _carService.Update(car);
            if (ModelState.IsValid)
            {
                ret = Ok(car);
            }
            else
            {
                return NotFound();
            }

            return ret;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}