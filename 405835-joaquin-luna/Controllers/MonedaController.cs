using _405835_joaquin_luna.ControlerModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _405835_joaquin_luna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MonedaController : ControllerBase
    {
        private static List<Moneda> lstMonedas=new List<Moneda>();

        // GET: api/<MonedaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lstMonedas);
        }

        // GET api/<MonedaController>/5
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
             foreach (var moneda in lstMonedas)
            {
                if (moneda.Nombre.Equals(nombre))
                {
                    return Ok(moneda);
                }
             
            }
            return NotFound("moneda no encontrada");
        }

        // POST api/<MonedaController>
        [HttpPost]
        public IActionResult Post([FromBody] Moneda moneda)
        {

            if (moneda==null||string.IsNullOrEmpty(moneda.Nombre))
            {
                return BadRequest("moneda incorrecta!!!");
            }
           

            lstMonedas.Add(moneda);

            return Ok(moneda);


        }

        //// PUT api/<MonedaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

       
    }
}
