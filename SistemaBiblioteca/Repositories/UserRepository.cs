
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Repositories
{

    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users; 

        public UserRepository(List<User> users) 
        {
            _users = users;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users.ToList(); 
        }

        public User GetUserByCPF(string cpf)
        {
            return _users.FirstOrDefault(u => u.CPF == cpf);
        }

        public void CreateUser(User user)
        {
            if (_users.Any(u => u.CPF == user.CPF))
            {
                throw new ArgumentException("User with the same CPF already exists.");
            }
            _users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.CPF == user.CPF);
            if (existingUser == null)
            {
                throw new ArgumentException("User not found for update.");
            }
            existingUser.Name = user.Name;
            existingUser.Address = user.Address;
        }

        public void DeleteUser(string cpf)
        {
            var user = _users.FirstOrDefault(u => u.CPF == cpf);
            if (user == null)
            {
                throw new ArgumentException("User not found for deletion.");
            }
            _users.Remove(user);
        }
    }

}

