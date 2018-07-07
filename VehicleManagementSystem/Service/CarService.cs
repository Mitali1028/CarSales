using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Repository;

namespace VehicleManagementSystem.Service
{
    public class CarService : IService<Car>
    {
        private IRepository<Car> _repository;
        public CarService()
        {
            if(_repository == null)
            {
                _repository = new CarRepository();
            }
        }
        public void Add(Car model)
        {
            _repository.Add(model);
        }

        public Car GetDateById(int id)
        {
            var model = _repository.GetDataById(id);
            return model;
        }

        public IEnumerable<Car> GetData()
        {
           var carData = _repository.Get();
           return carData;
        }

        public void Update(Car model)
        {
            _repository.Update(model);
        }
    }
}