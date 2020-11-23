using GestaoEstoque.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>, IDisposable
    {
        Usuario UsuarioValido(int id, string senha);
    }
}
