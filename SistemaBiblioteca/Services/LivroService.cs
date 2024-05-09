using Microsoft.Extensions.Logging;
using SistemaBiblioteca.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILogger<LivroService> _logger;
        private readonly List<Livro> _livros = new List<Livro>();

        public LivroService(ILogger<LivroService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Livro> GetLivros()
        {
            return _livros;
        }

        public Livro GetLivroById(int id)
        {
            return _livros.FirstOrDefault(l => l.Id == id);
        }

        public string CreateLivro(Livro livro)
        {
            if (_livros.Any(l => l.Id == livro.Id))
            {
                return "Livro com o mesmo Id já existe.";
            }

            _livros.Add(livro);
            return $"Livro criado com sucesso! ID: {livro.Id}";
        }

        public string UpdateLivro(int id, Livro updatedLivro)
        {
            var livro = _livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                return "Livro não encontrado.";
            }

            livro.Titulo = updatedLivro.Titulo;
            livro.Autor = updatedLivro.Autor;
            livro.Genero = updatedLivro.Genero;
            return "Informações do livro atualizadas com sucesso!";
        }

        public string DeleteLivro(int id)
        {
            var livro = _livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                return "Livro não encontrado.";
            }

            _livros.Remove(livro);
            return "Livro excluído com sucesso!";
        }
    }
}
