using GestaoEstoque.WebApi.Data;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace GestaoEstoque.WebApi.Repositories
{
    public class EstoqueRepository : BaseRepository<Agenda>, IEstoqueRepository
    {
        private Context _context;
        public EstoqueRepository(Context context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<Agenda> VerificarVaga(string dataInicio, string dataFim, string hrInicio, string hrFim)
        {
            var vaga = from a in _context.Agendas
                       where a.DtInicio == dataInicio
                            && a.DtFinal == dataFim
                            && a.HrInicial == hrInicio
                            && a.HrFinal == hrFim
                       select a;
                                
            return vaga;
        }
    }
}
