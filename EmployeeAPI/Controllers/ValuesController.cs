using BusinessServices.Layer.Interface;
using EmployeesDb.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmployeeBusiness<Project> _employeeBusiness;

        public ValuesController(IEmployeeBusiness<Project> employeeBusiness)
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
