using EmployeesDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.Layer.Interface
{
    public interface IEmployeeBusiness<T> where T: IEntity
    {
         public Task<T> AddEmployee(T employee);
         public Task<List<T>> Get();
    }
}
