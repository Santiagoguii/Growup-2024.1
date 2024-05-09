using System;
using System.Collections.Generic;
using System.Linq;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Repositories;
using SistemaBiblioteca.Services;


public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public User GetUserByCPF(string cpf)
    {
        return _userRepository.GetUserByCPF(cpf);
    }

    public void CreateUser(User user)
    {
        _userRepository.CreateUser(user);
    }

    public void UpdateUser(User user)
    {
        _userRepository.UpdateUser(user);
    }

    public void DeleteUser(string cpf)
    {
        _userRepository.DeleteUser(cpf);
    }

    public IEnumerable<User> GetUsers()
    {
        throw new NotImplementedException();
    }

    User IUserService.CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public User UpdateUser(string cpf, User updatedUser)
    {
        throw new NotImplementedException();
    }
}
