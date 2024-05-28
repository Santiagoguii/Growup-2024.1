using Emprestimo.Models;
using Emprestimo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emprestimo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;
        private readonly IAtividadeRegistroService _atividadeRegistroService;

        public LoanController(ILoanService loanService, IAtividadeRegistroService atividadeRegistroService)
        {
            _loanService = loanService;
            _atividadeRegistroService = atividadeRegistroService;
        }

        [HttpPost("lend")]
        public IActionResult LendBook(string UsuarioId, string LivroId)
        {
            try
            {
                var loan = _loanService.LendBook(UsuarioId, LivroId);
                return Ok(loan);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("return")]
        public IActionResult ReturnBook(int EmpId)
        {
            try
            {
                var message = _loanService.ReturnBook(EmpId);
                return Ok(message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("atividadesregistro")]
        public IActionResult GetAtividadesRegistro()
        {
            var atividadesRegistro = _atividadeRegistroService.GetAtividadesRegistro();
            return Ok(atividadesRegistro);
        }
    }
}
