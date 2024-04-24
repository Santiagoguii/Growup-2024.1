using Microsoft.EntityFrameworkCore;

namespace Crud_usuarios.Models
{
    public class Biblioteca : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud_usuarios; integrated Security=True");
        }
    }
}
