using GestaoEstoque.WebApi.Data;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace GestaoEstoque.WebApi.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private Context _context;
        public UsuarioRepository(Context context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> UsuarioValido(int id, string senha)
        {
            var usuario = from u in _context.Usuarios
                          where u.Senha == senha && u.Id == id
                          select u;

            return usuario;
        }
    }
}
