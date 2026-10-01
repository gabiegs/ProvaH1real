using ProvaH1.Repository;
using ProvaH1.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ProvaH1.Controllers;

namespace ProvaH1.Models
{
    [ApiController]
    [Route("[controller]")]
    public class ProvaController : ControllerBase
    {
        private readonly IProvaRepository _provaRepository;
        public ProvaController(IProvaRepository provaRepository)
        {
            _provaRepository = provaRepository;
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogador jogador)
        {
            try
            {
                _provaRepository.Cadastrar(jogador);

                return Ok("Jogador cadastrado com sucesso!");
            }
            catch (Exception)
            {
                return BadRequest("Jogador já cadastrado!");
            }
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult ListarJogador()
        {
            return Ok(_provaRepository.ObterTodos());
        }

        [HttpPost]
        public IActionResult Registrar(Peneira aprovado)
        {
            var jogador = _provaRepository.ObterTodos()
                .FirstOrDefault(v => v.CPF == aprovado.CPF);

            if (jogador == null)
            {
                return NotFound("Jogador não encontrado!");
            }

            _provaRepository.Registrar(aprovado);

            return Ok("Registrado com sucesso!");
        }
    }
}
