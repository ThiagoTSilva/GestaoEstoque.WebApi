﻿using GestaoEstoque.WebApi.Models;
using GestaoEstoque.WebApi.Repositories.Interface;
using GestaoEstoque.WebApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }
        public void CadastrarUsuario(Usuario usuario) 
        {
            _usuarioRepository.Save(usuario);

        }

        public List<Usuario> UsuarioValido(int id, string senha)
        {
            var usuario =_usuarioRepository.UsuarioValido(id, senha);

            return usuario.ToList();
          
        }
    }
}
