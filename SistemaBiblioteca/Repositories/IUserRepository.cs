using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Repositories
{
    public interface IUserRepository
    {
            IEnumerable<User> GetAllUsers();
            User GetUserByCPF(string cpf);
            void CreateUser(User user);
            void UpdateUser(User user);
            void DeleteUser(string cpf);
        }

    }

