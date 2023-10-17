using _405835_joaquin_luna.ControlerModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _405835_joaquin_luna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FechaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(new Fecha());
        }
        




    }
}
