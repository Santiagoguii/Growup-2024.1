using System.Collections.Generic;
using Crud_usuarios.Models;

namespace Crud_usuarios.Services
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
