using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly Biblioteca _dbContext;

        public LivroRepository(Biblioteca dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Livro> GetLivros()
        {
            return _dbContext.Set<Livro>().ToList();
        }

        public Livro GetLivroById(int id)
        {
            return _dbContext.Set<Livro>().FirstOrDefault(l => l.Id == id);
        }

        public void AddLivro(Livro livro)
        {
            _dbContext.Set<Livro>().Add(livro);
            _dbContext.SaveChanges();
        }

        public void UpdateLivro(Livro livro)
        {
            _dbContext.Entry(livro).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteLivro(int id)
        {
            var livro = _dbContext.Set<Livro>().FirstOrDefault(l => l.Id == id);
            if (livro != null)
            {
                _dbContext.Set<Livro>().Remove(livro);
                _dbContext.SaveChanges();
            }
        }
    }
}
