using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Repository
{
    public interface IRepository<T>
    {
        int Add(T model);
        void Update(T model);
        ICollection<T> Get();
        T GetDataById(int id);
    }
}
