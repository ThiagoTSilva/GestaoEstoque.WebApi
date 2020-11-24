using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Models.Dto
{
    public class AgendamentoDto
    {
        public string Status { get; set; }
        public string NomeFornecedor { get; set; }
        public int Vaga { get; set; }
        public string Placa { get; set; }
        public List<Validacao> ValidacaoDetalhada { get; set; }

    }
}
