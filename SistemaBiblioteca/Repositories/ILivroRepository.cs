using SistemaBiblioteca.Models;
using System.Collections.Generic;

namespace SistemaBiblioteca.Repositories
{
    public interface ILivroRepository
    {
        IEnumerable<Livro> GetLivros();
        Livro? GetLivroById(int id);
        IEnumerable<Livro> GetLivroByTitle(string title);
        IEnumerable<Livro> GetLivrosByAuthor(string autor);
        void AddLivro(Livro livro);
        void UpdateLivro(Livro livro);
        void DeleteLivro(int id);
    }
}
