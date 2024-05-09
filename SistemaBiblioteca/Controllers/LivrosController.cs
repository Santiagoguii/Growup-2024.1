using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Services;

namespace SistemaBiblioteca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILogger<LivrosController> _logger;
        private readonly ILivroService _livroService;
        public LivrosController(ILogger<LivrosController> logger, ILivroService livroService)
        {
            _logger = logger;
            _livroService = livroService;
        }

        [HttpGet]
        public IActionResult GetLivros()
        {
            var livros = _livroService.GetLivros();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public IActionResult GetLivroById(int id)
        {
            var livro = _livroService.GetLivroById(id);
            if (livro == null)
            {
                return NotFound("Livro não encontrado.");
            }
            return Ok(livro);
        }

        [HttpPost]
        public IActionResult CreateLivro([FromBody] Livro livro)
        {
            var result = _livroService.CreateLivro(livro);
            if (result.StartsWith("Livro criado com sucesso!"))
            {
                return CreatedAtAction(nameof(GetLivroById), new { id = livro.Id }, livro);
            }
            return Conflict(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLivro(int id, [FromBody] Livro updatedLivro)
        {
            var result = _livroService.UpdateLivro(id, updatedLivro);
            if (result == "Informações do livro atualizadas com sucesso!")
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLivro(int id)
        {
            var result = _livroService.DeleteLivro(id);
            if (result == "Livro excluído com sucesso!")
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
