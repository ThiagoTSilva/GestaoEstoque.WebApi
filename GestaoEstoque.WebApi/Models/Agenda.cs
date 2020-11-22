using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime DhInicio { get; set; }
        public DateTime DhFinal { get; set; }
    }
}
