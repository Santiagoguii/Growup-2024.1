using Microsoft.EntityFrameworkCore;
using Emprestimo.Models;

namespace Emprestimo.Data
{
    public class EmprestimoDbContext : DbContext
    {
        public EmprestimoDbContext(DbContextOptions<EmprestimoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Loan> Loans { get; set; }
        public DbSet<AtividadeRegistro> AtividadesRegistro { get; set; }
    }
}
