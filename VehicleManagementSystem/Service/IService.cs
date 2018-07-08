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
        int Add(T model);
        ICollection<T> GetData();
        T GetDateById(int id);
        void Update(T model);
    }
}
