using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Repositories;
using SistemaBiblioteca.Data;

namespace SistemaBiblioteca.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly DataContext _DbContext;

        public LivroRepository(DataContext DbContext)
        {
            _DbContext = DbContext;
        }

        public IEnumerable<Livro> GetLivros()
        {
            return _DbContext.Set<Livro>().ToList();
        }

        public Livro? GetLivroById(int id)
        {
            return _DbContext.Livros!.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<Livro> GetLivroByTitle(string title)
        {
            return _DbContext.Livros!.Where(l => l.Title.ToLower() == title.ToLower());
        }

        public IEnumerable<Livro> GetLivrosByAuthor(string author)
        {
            return _DbContext.Livros!.Where(l => l.Author.ToLower() == author.ToLower()); 
        }

        public void AddLivro(Livro livro)
        {
            _DbContext.Set<Livro>().Add(livro);
            _DbContext.SaveChanges();
        }

        public void UpdateLivro(Livro livro)
        {
            _DbContext.Entry(livro).State = EntityState.Modified;
            _DbContext.SaveChanges();
        }

        public void DeleteLivro(int id)
        {
            var livro = _DbContext.Set<Livro>().FirstOrDefault(l => l.Id == id);
            if (livro != null)
            {
                _DbContext.Set<Livro>().Remove(livro);
                _DbContext.SaveChanges();
            }
        }
    }
}
