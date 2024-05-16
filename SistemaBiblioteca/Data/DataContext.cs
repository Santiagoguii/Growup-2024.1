using SistemaBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaBiblioteca.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<User>? Users { get; set; }
        public DbSet<Livro>? Livros { get; set; }
    }
}
