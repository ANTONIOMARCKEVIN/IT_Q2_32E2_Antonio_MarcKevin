using IT_Q2_32E2_Antonio_MarcKevin.DTO.User;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IT_Q2_32E2_Antonio_MarcKevin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = new GetUsersResponse {
                Users = new()
                {
                    new(){ id = 1,name = "John Doe", email = "John.Doeexample.com" },
                    new(){ id = 2, name ="John Otto", email = "John.OttoExample.com" },
                    new(){ id = 3, name ="Lloyd Nathaniel Arciaga", email = "Lloyd.pogiExample.com" },
                    new(){ id = 4, name ="Nener Pisi", email = "Nener.PisiExample.com" },
                    new(){ id = 5, name ="Andrei Cabardo", email = "Andrei.PogiExample.com" },
                    new(){ id = 6, name ="LawrenceSoi Salomon", email = "Soi.PHExample.com" },
                    new(){ id = 7, name ="Alejandrew Manzano", email = "Alejandrew.MMMExample.com" },
                    new(){ id = 8, name ="Esmi Rin Hoy", email = "Esmi.rinHoyExample.com" },
                    new(){ id = 9, name ="Pinong Geralin ", email = "Pinong03.PHExample.com" },
                    new(){ id = 10, name ="Idol Neil Tumala", email = "Talapia.IdolExample.com" }
                }
            };
            return Ok(response);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var users = new List<GetUserByIdResponse>
            {
                new(){id = 1, Something = "Something"}
            };
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(users);
        }   

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserResponse user)
        {
            var users = new List<GetUserByIdResponse>
            {
                 
            };
            var User = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }



            return Ok(users);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
        }
    }
}
