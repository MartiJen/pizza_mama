using Microsoft.AspNetCore.Mvc;
using pizza_mama.Data;
using pizza_mama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        DataContext datacontext;
        public ApiController(DataContext datacontext)
        {
            this.datacontext = datacontext;
        }

        // GET: api/<ApiController>
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            //var pizza = new Pizza() { nom="Pizza test", prix = 8, vegetarienne = false, ingredients = "tomate, oignon, oeuf" };

            var pizzas = datacontext.Pizzas.ToList();

            return Json(pizzas);
        }

        // GET api/<ApiController>/5
        /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
