using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILogger<LivrosController> _logger;
        private readonly List<Livro> _livros = new List<Livro>();

        public LivrosController(ILogger<LivrosController> logger)
        {
            _logger = logger;
        }

        #region Listar livros
        [HttpGet]
        public IActionResult GetLivros()
        {
            return Ok(_livros);
        }

        // Obter um livro por Id
        [HttpGet("{id}")]
        public IActionResult GetLivroById(int id)
        {
            var livro = _livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                return NotFound("Livro não encontrado.");
            }
            return Ok(livro);
        }
        #endregion

        #region Criação de livro
        [HttpPost]
        public IActionResult CreateLivro([FromBody] Livro livro)
        {
            // Verifica se o livro já existe pelo Id
            if (_livros.Any(l => l.Id == livro.Id))
            {
                return Conflict("Livro com o mesmo Id já existe.");
            }

            _livros.Add(livro);
            return Ok($"Livro criado com sucesso! ID: {livro.Id}");
        }
        #endregion

        #region Atualizar livro
        [HttpPut("{id}")]
        public IActionResult UpdateLivro(int id, Livro updatedLivro)
        {
            var livro = _livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                return NotFound("Livro não encontrado.");
            }
            livro.Titulo = updatedLivro.Titulo;
            livro.Autor = updatedLivro.Autor;
            livro.Genero = updatedLivro.Genero;
            return Ok("Informações do livro atualizadas com sucesso!");
        }
        #endregion

        #region Deletar livro
        [HttpDelete("{id}")]
        public IActionResult DeleteLivro(int id)
        {
            var livro = _livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                return NotFound("Livro não encontrado.");
            }
            _livros.Remove(livro);
            return Ok("Livro excluído com sucesso!");
        }
        #endregion
    }
}