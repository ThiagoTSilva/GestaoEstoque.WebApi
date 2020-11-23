using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GestaoEstoque.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly IEstoqueService _service;

        public EstoqueController(IEstoqueService service) 
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(Agenda agenda)
        {
            return Ok(_service.AgendarHorario(agenda));
        }

    }
}
