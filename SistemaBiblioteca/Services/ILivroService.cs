using SistemaBiblioteca.Models;
using System.Collections.Generic;

namespace SistemaBiblioteca.Services
{
	public interface ILivroService
	{
		IEnumerable<Livro> GetLivros();
		Livro GetLivroById(int id);
		string CreateLivro(Livro livro);
		string UpdateLivro(int id, Livro updatedLivro);
		string DeleteLivro(int id);
	}
}
