using System;
using System.Collections.Generic;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Services;
using SistemaBiblioteca.Repositories;

namespace SistemaBiblioteca.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILogger<LivroService> _logger;
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILogger<LivroService> logger, ILivroRepository livroRepository)
        {
            _logger = logger;
            _livroRepository = livroRepository;
        }

        public IEnumerable<Livro> GetLivros()
        {
            return _livroRepository.GetLivros();
        }

        public Livro GetLivroById(int id)
        {
            return _livroRepository.GetLivroById(id);
        }

        public IEnumerable<Livro> GetLivroByTitle(string title)
        {
            return _livroRepository.GetLivroByTitle(title);
        }

        public IEnumerable<Livro> GetLivrosByAuthor(string autor)
        {
            return _livroRepository.GetLivrosByAuthor(autor);
        }

        public string CreateLivro(Livro livro)
        {
            try
            {
                _livroRepository.AddLivro(livro);
                return $"Livro criado com sucesso! ID: {livro.Id}";
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao criar livro: {ex.Message}");
                throw;
            }
        }

        public string UpdateLivro(int id, Livro updatedLivro)
        {
            try
            {
                var livro = _livroRepository.GetLivroById(id);
                if (livro == null)
                {
                    return "Livro não encontrado.";
                }

                livro.Title = updatedLivro.Title;
                livro.Author = updatedLivro.Author;
                livro.Genre = updatedLivro.Genre;

                _livroRepository.UpdateLivro(livro);
                return "Informações do livro atualizadas com sucesso!";
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao atualizar livro: {ex.Message}");
                throw;
            }
        }

        public string DeleteLivro(int id)
        {
            try
            {
                var livro = _livroRepository.GetLivroById(id);
                if (livro == null)
                {
                    return "Livro não encontrado.";
                }

                _livroRepository.DeleteLivro(id);
                return "Livro excluído com sucesso!";
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao excluir livro: {ex.Message}");
                throw;
            }
        }
    }
}
