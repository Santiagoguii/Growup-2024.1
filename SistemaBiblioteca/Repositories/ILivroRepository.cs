using SistemaBiblioteca.Models;
using System.Collections.Generic;

namespace SistemaBiblioteca.Repositories
{
    public interface ILivroRepository
    {
        IEnumerable<Livro> GetLivros();
        Livro? GetLivroById(int id);
        Livro? GetLivroByTitle(string title);
        void AddLivro(Livro livro);
        void UpdateLivro(Livro livro);
        void DeleteLivro(int id);
    }
}
