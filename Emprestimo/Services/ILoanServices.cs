using Emprestimo.Models;
using Emprestimo.Data;
using System;
using System.Linq;

namespace Emprestimo.Services
{
    public interface ILoanService
    {
        Loan LendBook(string UsuarioId, string LivroId);
        string ReturnBook(int EmpId);
    }

    public class LoanService : ILoanService
    {
        private const int MaxLoansPerUser = 3;
        private readonly EmprestimoDbContext _context;
        private readonly IAtividadeRegistroService _atividadeRegistroService;

        public LoanService(EmprestimoDbContext context, IAtividadeRegistroService atividadeRegistroService)
        {
            _context = context;
            _atividadeRegistroService = atividadeRegistroService;
        }

        public Loan LendBook(string UsuarioId, string LivroId)
        {
            if (_context.Loans.Count(l => l.UsuarioId == UsuarioId && !l.IsReturned) >= MaxLoansPerUser)
            {
                throw new Exception("O usuário já tem o máximo de livros emprestados.");
            }

            if (_context.Loans.Any(l => l.LivroId == LivroId && !l.IsReturned))
            {
                throw new Exception("O livro já está emprestado.");
            }

            var loan = new Loan
            {
                UsuarioId = UsuarioId,
                LivroId = LivroId,
                LoanDate = DateTime.Now,
                IsReturned = false
            };
            _context.Loans.Add(loan);
            _context.SaveChanges();

            var atividadeRegistro = new AtividadeRegistro
            {
                DataHora = DateTime.Now,
                TipoAtividade = "Empréstimo",
                LivroId = LivroId,
                UsuarioId = UsuarioId
            };
            _atividadeRegistroService.RegistrarAtividade(atividadeRegistro);

            return loan;
        }

        public string ReturnBook(int EmpId)
        {
            var loan = _context.Loans.FirstOrDefault(l => l.Id == EmpId);
            if (loan == null)
            {
                throw new Exception("Empréstimo não encontrado.");
            }

            if (loan.IsReturned)
            {
                throw new Exception("O livro já foi devolvido.");
            }

            loan.IsReturned = true;
            _context.SaveChanges();

            var atividadeRegistro = new AtividadeRegistro
            {
                DataHora = DateTime.Now,
                TipoAtividade = "Devolução",
                LivroId = loan.LivroId,
                UsuarioId = loan.UsuarioId
            };
            _atividadeRegistroService.RegistrarAtividade(atividadeRegistro);

            return "Livro devolvido com sucesso.";
        }
    }
}
