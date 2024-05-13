using System;
using System.Collections.Generic;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Services;
using SistemaBiblioteca.Repositories;

namespace SistemaBiblioteca.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserByCPF(string cpf)
        {
            return _userRepository.GetUserByCPF(cpf);
        }

        public User CreateUser(User user)
        {
            if (_userRepository.GetUserByCPF(user.CPF) != null)
            {
                throw new InvalidOperationException("Usuário com o mesmo CPF já existe.");
            }

            _userRepository.CreateUser(user);
            return user;
        }

        public User UpdateUser(string cpf, User updatedUser)
        {
            var existingUser = _userRepository.GetUserByCPF(cpf);
            if (existingUser == null)
            {
                throw new InvalidOperationException("Usuário não encontrado.");
            }

            existingUser.Name = updatedUser.Name;
            existingUser.Address = updatedUser.Address;
            existingUser.Phone = updatedUser.Phone;
            existingUser.City = updatedUser.City;
            existingUser.State = updatedUser.State;
            existingUser.PostalCode = updatedUser.PostalCode;
            existingUser.Neighborhood = updatedUser.Neighborhood;
            existingUser.Street = updatedUser.Street;
            existingUser.ResidenceNumber = updatedUser.ResidenceNumber;

            _userRepository.UpdateUser(existingUser);
            return existingUser;
        }

        public void DeleteUser(string cpf)
        {
            var existingUser = _userRepository.GetUserByCPF(cpf);
            if (existingUser == null)
            {
                throw new InvalidOperationException("Usuário não encontrado.");
            }

            _userRepository.DeleteUser(cpf);
        }
    }
}
