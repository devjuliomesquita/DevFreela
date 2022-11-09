using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsControllers: ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly OpeningTimeOption _option;
        public ProjectsControllers(IOptions<OpeningTimeOption> option)
        {
            _option = option.Value;
        }

        // api/projects?query=net core //
        [HttpGet]//COSULTANDO VÁRIOS
        public IActionResult Get(string query)
        {
            return Ok();//PROTOCOLO DE RESPOSTA 200
        }

        //api/projects/1
        [HttpGet("{id}")]//CONSULTANOD SOMENTE 1
        public IActionResult GetById(int Id)
        {
            return Ok(); //OU return NotFound();
        }

        [HttpPost]// CADASTRANDO O OBJETO
        public IActionResult Post([FromBody] CreatProjectModel creatProject)
        {
            if (creatProject.Title.Length > 50)//APENAS TESTE DO TAMANHO DO TITULO
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new {id = creatProject.Id}, creatProject); //NECESSÁRIO 3 PARAMETROS
        }

        //api/projects/2
        [HttpPut("{id}")]//ATUALIZANDO O OBJETO
        public IActionResult Put(int Id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }
            return NoContent();
        }

        //api/projectts/3
        [HttpDelete("{id}")]//DELETAR USUÁRIO
        public IActionResult Delete(int Id)
        {
            return NoContent();//CASO NÃO ENCONTRE return NotFound();
        }

        //api/projects/1/comments
        [HttpPost("{id}/comments")]//CADASTRO DE COMENTÁRIOS
        public IActionResult PostComment(int id, [FromBody] CreatCommentModel creatComment)
        {
            return Ok();
        }

        //api/projets/1/start
        [HttpPut("{id}/start")]//INICIALIZAÇÃO DA API
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //api/projects/1/finis
        [HttpPut("{id}/finish")]//FINALIZAÇÃO DA API
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
