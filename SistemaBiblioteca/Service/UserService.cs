using System;
using System.Collections.Generic;
using System.Linq;
using Crud_usuarios.Models;

namespace Crud_usuarios.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User GetUserByCPF(string cpf)
        {
            var user = _users.FirstOrDefault(u => u.CPF == cpf);
            if (user == null)
            {
                throw new InvalidOperationException("Usuário não encontrado.");
            }
            return user;
        }

        public User CreateUser(User user)
        {
            if (_users.Any(u => u.CPF == user.CPF))
            {
                throw new InvalidOperationException("Usuário com o mesmo CPF já existe.");
            }

            _users.Add(user);
            return user;
        }

        public User UpdateUser(string cpf, User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.CPF == cpf);
            if (user == null)
            {
                throw new InvalidOperationException("Usuário não encontrado.");
            }

            user.Name = updatedUser.Name;
            user.Address = updatedUser.Address;
            user.Telephone = updatedUser.Telephone;
            user.City = updatedUser.City;
            user.State = updatedUser.State;
            user.PostalCode = updatedUser.PostalCode;
            user.Neighborhood = updatedUser.Neighborhood;
            user.Street = updatedUser.Street;
            user.ResidenceNumber = updatedUser.ResidenceNumber;

            return user;
        }

        public void DeleteUser(string cpf)
        {
            var user = _users.FirstOrDefault(u => u.CPF == cpf);
            if (user == null)
            {
                throw new InvalidOperationException("Usuário não encontrado.");
            }

            _users.Remove(user);
        }
    }
}
