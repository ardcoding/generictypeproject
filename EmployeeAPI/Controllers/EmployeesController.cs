using BusinessServices.Layer.Interface;
using DataAcess.Layer.Interface;
using EmployeesDb.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeBusiness<Employee> _employeeBusiness;

        public EmployeesController(IEmployeeBusiness<Employee> employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }
        [HttpGet]
        public async Task<List<Employee>> GetValue()
        {
            return await _employeeBusiness.Get();
        }
    }
}
