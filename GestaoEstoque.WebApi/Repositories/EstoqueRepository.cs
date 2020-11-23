using GestaoEstoque.WebApi.Data;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Repositories.Interface;

namespace GestaoEstoque.WebApi.Repositories
{
    public class EstoqueRepository : BaseRepository<Agenda>, IEstoqueRepository
    {
        public EstoqueRepository(Context context)
            : base(context)
        {
            
        }
    }
}
