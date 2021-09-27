﻿using Microsoft.AspNetCore.Http;
using SpMedicalGroup.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup.WebAPI.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);

        void Cadastrar(Usuario novoUsuario);
        void Atualizar(int idUsuario, Usuario usuarioAtualizado);
        void Deletar(int idUsuario);
        Usuario ListarPorId(int idUsuario);
        Usuario ListarPorCPF(string CPF);
        void SalvarPerfilBd(IFormFile foto, int id_usuario);
        string ConsultarperfilBd(int id_usuario);
    }
}
