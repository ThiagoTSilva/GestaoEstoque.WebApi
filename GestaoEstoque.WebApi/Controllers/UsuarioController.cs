using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GestaoEstoque.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            _service.CadastrarUsuario(usuario);
            return Ok();
        }

        [HttpGet("~/Api/Usuario/{id}/{senha}")]
        public IActionResult UsuarioValido(int id, int senha) 
        {
            return Ok(_service.UsuarioValido(id, senha));
        }
    }
}
