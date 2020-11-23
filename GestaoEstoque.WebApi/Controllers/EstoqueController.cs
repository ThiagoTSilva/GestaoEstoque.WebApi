using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult Post()
        {
            _service.AgendarHorario();
            return Ok();
        }
    }
}
