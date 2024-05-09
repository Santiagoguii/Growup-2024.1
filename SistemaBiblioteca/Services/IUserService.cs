using System.Collections.Generic;
using SistemaBiblioteca.Models;

using System.Collections.Generic;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUserByCPF(string cpf);
        User CreateUser(User user);
        User UpdateUser(string cpf, User updatedUser);
        void DeleteUser(string cpf);
    }
}

