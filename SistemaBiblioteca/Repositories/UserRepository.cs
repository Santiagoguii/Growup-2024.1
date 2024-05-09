using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Repositories;
using SistemaBiblioteca.Data;

namespace SistemaBiblioteca.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _DbContext;

        public UserRepository(DataContext dbContext)
        {
            _DbContext = dbContext;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _DbContext.Users.ToList();
        }

        public User GetUserByCPF(string cpf)
        {
            return _DbContext.Users.FirstOrDefault(u => u.CPF == cpf);
        }

        public void CreateUser(User user)
        {
            _DbContext.Users.Add(user);
            _DbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _DbContext.Entry(user).State = EntityState.Modified;
            _DbContext.SaveChanges();
        }

        public void DeleteUser(string cpf)
        {
            var user = _DbContext.Users.FirstOrDefault(u => u.CPF == cpf);
            if (user != null)
            {
                _DbContext.Users.Remove(user);
                _DbContext.SaveChanges();
            }
        }
    }
}

