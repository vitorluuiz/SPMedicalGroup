﻿using Microsoft.AspNetCore.Http;
using SpMedicalGroup.WebAPI.Contexts;
using SpMedicalGroup.WebAPI.Domains;
using SpMedicalGroup.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup.WebAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SPClinicalContext ctx = new();
        public void Atualizar(int idUsuario, Usuario usuarioAtualizado)
        {
            Usuario usuarioDesatualizado = ctx.Usuarios.Find(idUsuario);

            if(usuarioAtualizado.Nome != null)
            {
                usuarioDesatualizado.Nome = usuarioAtualizado.Nome;
                ctx.Update(usuarioDesatualizado);
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);
            ctx.SaveChanges();
        }

        public string ConsultarperfilBd(int id_usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idUsuario)
        {
            ctx.Usuarios.Remove(ListarPorId(idUsuario));
            ctx.SaveChanges();
        }

        public List<Usuario> ListarUsuarios()
        {
            return ctx.Usuarios.Select(u =>  new Usuario
            {
                Email = u.Email,
                Nome = u.Nome,
                IdTipoUsuarioNavigation = new TipoUsuario()
                {
                    Tipo = u.IdTipoUsuarioNavigation.Tipo
                }
            }).ToList();
        }

        public Usuario ListarPorId(int idUsuario)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == idUsuario);
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public void SalvarPerfilBd(IFormFile foto, int id_usuario)
        {
            throw new NotImplementedException();
        }
    }
}
