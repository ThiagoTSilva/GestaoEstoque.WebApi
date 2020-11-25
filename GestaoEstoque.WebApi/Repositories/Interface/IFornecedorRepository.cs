using GestaoEstoque.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories.Interface
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor>, IDisposable
    {
    }
}
