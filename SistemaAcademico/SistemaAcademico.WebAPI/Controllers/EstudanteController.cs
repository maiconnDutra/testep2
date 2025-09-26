using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Dominio;
using SistemaAcademico.Servico;

namespace SistemaAcademico.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Estudantes")]
    public class EstudanteController : ControllerBase
    {
        private readonly IEstudanteServico _estudanteServico;

        public EstudanteController(IEstudanteServico estudanteServico)
        {
            _estudanteServico = estudanteServico;
        }

        [HttpGet]
        public IActionResult Listar() => Ok(_estudanteServico.ObterTodos());

        [HttpGet("{id}")]
        public IActionResult Obter(int id)
        {
            var estudante = _estudanteServico.ObterPorId(id);
            if (estudante == null) return NotFound();
            return Ok(estudante);
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] Estudante estudante)
        {
            _estudanteServico.AdicionarEstudante(estudante.Nome, estudante.Nota);
            return Ok(estudante);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Estudante estudante)
        {
            estudante.Id = id;
            _estudanteServico.AtualizarEstudante(estudante);
            return Ok(estudante);
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _estudanteServico.RemoverEstudante(id);
            return NoContent();
        }
    }
}
