using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Service.Interface
{
    public interface IEstoqueService
    {
        AgendamentoDto AgendarHorario(Agenda agenda);
    }
}
