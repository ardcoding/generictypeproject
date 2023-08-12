using EmployeesDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Layer.Interface
{
    public interface IEmployeeRepository<T> where T: IEntity
    {
        public Task<T> Add(T entity);
        public Task<List<T>> Get();
    }
}
