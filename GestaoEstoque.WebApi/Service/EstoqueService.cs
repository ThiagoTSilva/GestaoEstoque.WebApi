using GestaoEstoque.WebApi.Repositories.Interface;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Service
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;
        public EstoqueService(IEstoqueRepository estoqueRepository) 
        {
            _estoqueRepository = estoqueRepository;
        }

        public IEnumerable<Agenda> AgendarHorario(Agenda agenda)
        {

            _estoqueRepository.Save(agenda);

            return agenda;
        }

        private List<Validacao> ValidarAgendamento(Agenda agenda)
        { 
            var validarDetalhe = new List<Validacao>();

            var vagas = _estoqueRepository.VerificarVaga(agenda.DtInicio, agenda.DtFinal, agenda.HrInicial, agenda.HrFinal);

            foreach (var vaga in vagas) 
            {
                if (vaga.Vaga == agenda.Vaga) 
                {
                    var validar = new Validacao
                    {
                        Sucesso = false,
                        Mensagem = "Vaga já esta ocupada."
                    };

                    validarDetalhe.Add(validar);
                }

            }
            return validarDetalhe;
        }
    }
}
