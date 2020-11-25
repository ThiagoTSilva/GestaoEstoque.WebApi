using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpGet("~/api/usuario/{id}/{senha}")]
        public async Task<IActionResult> UsuarioValido(int id, string senha) 
        {
            var usuario = _service.UsuarioValido(id, senha);
            
            if(usuario.Count == 0) 
                return NoContent();

            return Ok(usuario);


        }
    }
}
