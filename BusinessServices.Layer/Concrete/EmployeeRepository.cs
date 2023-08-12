using BusinessServices.Layer.Interface;
using EmployeesDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessServices.Layer.Concrete
{
    public class EmployeeBusiness<T>:IEmployeeBusiness<T> where T : class, IEntity 
    {
            private readonly EmployeesDbContext _dbcontext;

            public EmployeeBusiness(EmployeesDbContext dbcontext)
            {
                _dbcontext = dbcontext;
            }   

            public async Task<T> AddEmployee(T entity)
            {
                await _dbcontext.Set<T>().AddAsync(entity);
                await _dbcontext.SaveChangesAsync();
                return entity;
            }

            public async Task<List<T>> Get()
            {
                return await _dbcontext.Set<T>().ToListAsync();
            }
     }
}
