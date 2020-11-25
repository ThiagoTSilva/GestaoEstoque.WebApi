using GestaoEstoque.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories.Interface
{
    public interface IEstoqueRepository : IBaseRepository<Agenda>, IDisposable
    {
        IEnumerable<Agenda> VerificarVaga(string dataInicio, string dataFim, string hrInicio, string hrFim);
        IEnumerable<Agenda> VerificarVagaFornecedor(string nomeFornecedor, string dataInicio, string dataFim, string hrInicio, string hrFim);
        IEnumerable<Agenda> Lotacao(string dataInicio, string dataFim);
    }
}
