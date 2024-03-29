﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedicalGroup.WebAPI.Domains;
using SpMedicalGroup.WebAPI.Interfaces;
using SpMedicalGroup.WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private IPacienteRepository _pacienteRepository { get; set; }

        public PacienteController()
        {
            _pacienteRepository = new PacientesRepository();
        }

        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar(Paciente novoPaciente)
        {
            _pacienteRepository.Cadastrar(novoPaciente);
            return StatusCode(201);
        }


        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            _pacienteRepository.Listar();
            return Ok();
        }

        [HttpDelete("Deletar/{idUsuario}")]
        public IActionResult Deletar(int idUsuario)
        {
            _pacienteRepository.Deletar(idUsuario);
            return Ok();
        }

        [HttpGet("Id/{idPaciente}")]
        public IActionResult ListarPorId(int idPaciente)
        {
            _pacienteRepository.ListarPorId(idPaciente);
            return Ok();
        }

    }
}
