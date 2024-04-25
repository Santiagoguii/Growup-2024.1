using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud_usuarios.Models;
using Crud_usuarios.Services;

namespace Crud_usuarios.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserService _userService;

        public UsersController(ILogger<UsersController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }

        [HttpGet("{cpf}")]
        public IActionResult GetUserByCPF(string cpf)
        {
            var user = _userService.GetUserByCPF(cpf);
            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                var createdUserId = _userService.CreateUser(user);
                return Ok($"Usuário criado com sucesso! ID: {createdUserId}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao criar usuário: {ex.Message}");
            }
        }

        [HttpPut("{cpf}")]
        public IActionResult UpdateUser(string cpf, User updatedUser)
        {
            try
            {
                _userService.UpdateUser(cpf, updatedUser);
                return Ok("Informações do usuário atualizadas com sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao atualizar usuário: {ex.Message}");
            }
        }

        [HttpDelete("{cpf}")]
        public IActionResult DeleteUser(string cpf)
        {
            try
            {
                _userService.DeleteUser(cpf);
                return Ok("Usuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao excluir usuário: {ex.Message}");
            }
        }
    }
}