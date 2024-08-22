using _03_Routing_Verbs_Web_Api.Controllers.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_Routing_Verbs_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        List<EmployeeDTO> employees = new List<EmployeeDTO>();

        public EmployeesController()
        {
            employees.Add(new EmployeeDTO { id = 1, name = "Nombre1", position = "Programador"} );
            employees.Add(new EmployeeDTO { id = 2, name = "Nombre2", position = "Programador" });
            employees.Add(new EmployeeDTO { id = 3, name = "Nombre3", position = "Desarrollador" });
        }


        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees() {
            if (employees.Count() > 0)
                return Ok(employees);
            return NotFound();
        }

        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
           var employee =  employees.Find(x => x.id == id);
            
            if(employee != null)
                return Ok(employee);
            return NotFound();
        }


        [HttpPost("CreateEmployee")]
        public IActionResult CreateEmployee([FromBody] EmployeeDTO employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }


    }
}
