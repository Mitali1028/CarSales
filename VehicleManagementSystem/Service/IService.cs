using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Service
{
   public interface IService<T>
    {
        void Add(T model);
        IEnumerable<T> GetData();
        T GetDateById(int id);
        void Update(T model);
    }
}
