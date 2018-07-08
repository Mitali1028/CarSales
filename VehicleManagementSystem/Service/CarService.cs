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
            _repository = new CarRepository();
        }
        public CarService(IRepository<Car> repository)
        {           
            _repository = repository;            
        }
        public int Add(Car model)
        {
          var id  = _repository.Add(model);
          return id;
        }

        public Car GetDateById(int id)
        {
            var model = _repository.GetDataById(id);
            return model;
        }

        public ICollection<Car> GetData()
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