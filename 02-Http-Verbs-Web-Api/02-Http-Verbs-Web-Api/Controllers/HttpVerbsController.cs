using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace _02_Http_Verbs_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpVerbsController : ControllerBase
    {
        [HttpGet("{id:long}")]
        public IActionResult Get(long id)
        {
            return Ok(new { message = "estoy es un get " + id });
        }


        [HttpPost]
        public IActionResult Post()
        {
            return Ok(new { message = "estoy es un postt" });
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok(new { message = "estoy es un put" });
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok(new { message = "estoy es un delete" });
        }
       
    }
}
