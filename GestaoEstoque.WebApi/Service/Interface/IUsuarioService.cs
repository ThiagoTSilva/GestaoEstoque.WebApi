using GestaoEstoque.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Service.Interface
{
    public interface IUsuarioService
    {
        void CadastrarUsuario(Usuario usuario);
        IEnumerable<Usuario> UsuarioValido(int id, string senha);
    }
}
