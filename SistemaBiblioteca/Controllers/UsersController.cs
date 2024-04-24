using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud_usuarios.Models;

namespace Crud_usuarios.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly List<User> _users = new List<User>();

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        // Obter todos os usu�rios
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_users);
        }

        // Obter um usu�rio por CPF
        [HttpGet("{cpf}")]
        public IActionResult GetUserByCPF(string cpf)
        {
            var user = _users.FirstOrDefault(u => u.CPF == cpf);
            if (user == null)
            {
                return NotFound("Usu�rio n�o encontrado.");
            }
            return Ok(user);
        }
        
        // Criar um novo usu�rio
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            // Verifica se o usuário já existe pelo CPF
            if (_users.Any(u => u.CPF == user.CPF))
            {
                return Conflict("Usuário com o mesmo CPF já existe.");
            }

            _users.Add(user);
            return Ok($"Usuário criado com sucesso! ID: {user.CPF}");
        }

        // Atualizar informa��es do usu�rio
        [HttpPut("{cpf}")]
        public IActionResult UpdateUser(string cpf, User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.CPF == cpf);
            if (user == null)
            {
                return NotFound("Usu�rio n�o encontrado.");
            }
            user.Name = updatedUser.Name;
            user.Address = updatedUser.Address;
            user.City = updatedUser.Telephone;
            user.City = updatedUser.City;
            user.State = updatedUser.State;
            user.PostalCode = updatedUser.PostalCode;
            user.Neighborhood = updatedUser.Neighborhood;
            user.Street = updatedUser.Street;
            user.ResidenceNumber = updatedUser.ResidenceNumber;
            return Ok("Informa��es do usu�rio atualizadas com sucesso!");
        }

        // Excluir um usu�rio
        [HttpDelete("{cpf}")]
        public IActionResult DeleteUser(string cpf)
        {
            var user = _users.FirstOrDefault(u => u.CPF == cpf);
            if (user == null)
            {
                return NotFound("Usu�rio n�o encontrado.");
            }
            _users.Remove(user);
            return Ok("Usu�rio exclu�do com sucesso!");
        }
    }
}
