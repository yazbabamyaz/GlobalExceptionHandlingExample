using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptinHandlingApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<string> person = new List<string>
        {
            "Ali","Veli","Ayşe"
        };

        [HttpGet]
        public IActionResult Get() 
        {
            if (person==null)
            {
                throw new Exception();
            }
            return Ok(person);
        }

    }
}
