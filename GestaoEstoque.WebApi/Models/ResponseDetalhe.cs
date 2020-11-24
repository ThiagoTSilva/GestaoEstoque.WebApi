using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Models
{
    public class ResponseDetalhe
    {
        public int Status { get; set; }
        public string Msg { get; set; }
        public dynamic Dados { get; set; }
    }
}
