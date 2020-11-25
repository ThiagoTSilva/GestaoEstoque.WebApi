using GestaoEstoque.WebApi.Data;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(Context context) : base(context)
        {
        }
    }
}
