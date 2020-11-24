using GestaoEstoque.WebApi.Repositories.Interface;
using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoEstoque.WebApi.Models.Dto;

namespace GestaoEstoque.WebApi.Service
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;
        public EstoqueService(IEstoqueRepository estoqueRepository) 
        {
            _estoqueRepository = estoqueRepository;
        }

        public AgendamentoDto AgendarHorario(Agenda agenda)
        {
            bool validacao = true;

            var isValid = this.ValidarAgendamento(agenda);

            foreach (var valido in isValid)
                if (!valido.Sucesso)
                    validacao = false;

            if(!validacao)
                _estoqueRepository.Save(agenda);

            var agendamentoDto = new AgendamentoDto
            {
                Status = agenda.Status,
                NomeFornecedor = agenda.Fornecedor.Nome,
                Placa = agenda.Placa,
                Vaga = agenda.Vaga,
                ValidacaoDetalhada = isValid
            };

            return agendamentoDto;
        }
   
        private List<Validacao> ValidarAgendamento(Agenda agenda)
        { 
            var validarDetalhe = new List<Validacao>();

            var horario = TimeSpan.Parse(agenda.HrFinal) - TimeSpan.Parse(agenda.HrFinal);

            var estoque = _estoqueRepository.VerificarVaga(agenda.DtInicio, agenda.DtFinal, agenda.HrInicial, agenda.HrFinal);

            foreach (var vaga in estoque) 
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

            if (estoque.Count() == 3) 
            {
                var validar = new Validacao
                {
                    Sucesso = false,
                    Mensagem = "Não a vaga para o horário selecionado."
                };

                validarDetalhe.Add(validar);
            }

            if (horario.Minutes > 60) 
            {
                var validar = new Validacao
                {
                    Sucesso = false,
                    Mensagem = "Vaga não pode ficar ocupada por mais de uma hora."
                };

                validarDetalhe.Add(validar);
            }

            var VagaFornecedor = _estoqueRepository.VerificarVagaFornecedor(agenda.Fornecedor.Nome, agenda.DtInicio, agenda.DtFinal, agenda.HrInicial, agenda.HrFinal);

            if (VagaFornecedor.Count() > 2) 
            {
                var validar = new Validacao
                {
                    Sucesso = false,
                    Mensagem = "Fornecedor não pode ocupar todas as vagas do horário."
                };

                validarDetalhe.Add(validar);
            }

            var lotacao = _estoqueRepository.Lotacao(agenda.DtInicio, agenda.DtFinal);

            if (lotacao.Count() > 12) 
            {
                var validar = new Validacao
                {
                    Sucesso = false,
                    Mensagem = "Não existe mais vagas disponível."
                };

                validarDetalhe.Add(validar);
            }

            return validarDetalhe;
        }
    }
}
