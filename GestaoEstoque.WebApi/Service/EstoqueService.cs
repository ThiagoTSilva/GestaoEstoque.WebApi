﻿using GestaoEstoque.WebApi.Repositories.Interface;
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

        public IEnumerable<Task<Agenda>> AgendarHorario()
        {
            var agendamento = new Agenda();
            _estoqueRepository.Save(agendamento);

            return (IEnumerable<Task<Agenda>>)agendamento;
        }
    }
}