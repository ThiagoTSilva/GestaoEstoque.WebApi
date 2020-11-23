using GestaoEstoque.WebApi.Data;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private Context _context;
        public UsuarioRepository(Context context)
         : base(context)
        {
            _context = context;
        }

        public Usuario UsuarioValido(int id, string senha)
        {
            IQueryable<Usuario> query = _context.Usuarios;
            query = query.Where(u => u.Senha == senha && u.Id == id);

            return (Usuario)query;
        }
    }
}
