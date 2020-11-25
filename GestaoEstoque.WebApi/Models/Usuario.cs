using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Models
{
    public class Usuario
    {
        public Usuario() 
        {
            DhCadastro = DateTime.Now;
            DhAtualizacao = DateTime.Now;
            Status = true;
        }

        public int Id { get; set; }
        public string Senha { get; set; }
        public DateTime DhCadastro { get; set; } 
        public DateTime DhAtualizacao { get; set; }
        public bool Status { get; set; }
        public string Nome { get; set; }
    }
}
