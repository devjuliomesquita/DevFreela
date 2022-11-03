using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    
    public class UsersController: ControllerBase
    {
        [HttpGet("{id}")]//CONSULTANDO USUÁRIO
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]//CADASTRANDO O USUÁRIO
        public IActionResult Post([FromBody] CreatUsersModel creatUsers)
        {
            return CreatedAtAction(nameof(GetById), new {id = 1}, creatUsers);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] CreatLoginModel creatLogin)
        {
            return NoContent();
        }
    }
}
