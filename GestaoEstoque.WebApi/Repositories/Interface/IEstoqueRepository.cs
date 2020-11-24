using GestaoEstoque.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories.Interface
{
    public interface IEstoqueRepository : IBaseRepository<Agenda>, IDisposable
    {
        IEnumerable<Agenda> VerificarVaga(string dataInicio, string dataFim, string dhInicio, string HrFim);
    }
}
