namespace GestaoEstoque.WebApi.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string DtInicio { get; set; }
        public string DtFinal { get; set; }
        public string HrInicial { get; set; }
        public string HrFinal { get; set; }
        public string Placa { get; set; }
        public int Vaga { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
