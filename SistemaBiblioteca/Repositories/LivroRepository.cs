using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Data;
using SistemaBiblioteca.Models;
using System.Collections.Generic;
using System.Linq;

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
            return _DbContext.livros!.FirstOrDefault(l => l.Id == id);
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
