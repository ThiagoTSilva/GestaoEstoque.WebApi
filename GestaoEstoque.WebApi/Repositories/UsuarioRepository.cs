using GestaoEstoque.WebApi.Data;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context context)
         : base(context)
        {
        }
    }
}
