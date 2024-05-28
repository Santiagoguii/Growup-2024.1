using Emprestimo.Models;
using Emprestimo.Data;
using System.Collections.Generic;
using System.Linq;

namespace Emprestimo.Services
{
    public interface IAtividadeRegistroService
    {
        void RegistrarAtividade(AtividadeRegistro atividadeRegistro);
        List<AtividadeRegistro> GetAtividadesRegistro();
    }

    public class AtividadeRegistroService : IAtividadeRegistroService
    {
        private readonly EmprestimoDbContext _context;

        public AtividadeRegistroService(EmprestimoDbContext context)
        {
            _context = context;
        }

        public void RegistrarAtividade(AtividadeRegistro atividadeRegistro)
        {
            _context.AtividadesRegistro.Add(atividadeRegistro);
            _context.SaveChanges();
        }

        public List<AtividadeRegistro> GetAtividadesRegistro()
        {
            return _context.AtividadesRegistro.ToList();
        }
    }
}
