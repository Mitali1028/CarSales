using System.Collections.Generic;
using System.Linq;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Repository
{
    public class CarRepository : IRepository<Car>
    {
        static List<Car> listOfCars = new List<Car>
        {
            new Car
            {
                Id = 1,
                Make = "Toyato",
                Model = "Aurion",
                NoOfDoors = 4,
                Engine = "ss",
                BodyType = "sedan"

            },
            new Car
            {
                Id = 2,
                Make = "Audi",
                Model = "v6",
                NoOfDoors = 4,
                Engine = "ss",
                BodyType = "Sedan"
            },
            new Car
            {
                Id = 3,
                Make = "Toyato",
                Model = "Cambri",
                NoOfDoors = 4,
                Engine = "v6",
                BodyType = "hatchback"
            }
        };

        public int Add(Car model)
        {
            if (model != null)
            {
                listOfCars.Add(model);
            }
            return model.Id;
        }

        public ICollection<Car> Get()
        {
            var model = from r in listOfCars
                        select r;
            return model.ToList();
        }

        public Car GetDataById(int id)
        {
            if (id > 0)
            {
                var model = (from r in listOfCars
                             where r.Id == id
                             select r).FirstOrDefault();
                return model;
            }
            return null;
        }

        public void Update(Car model)
        {
            var index = listOfCars.FindIndex(l => l.Id == model.Id);         
            listOfCars[index] = model;
        }
        
    }

    
}