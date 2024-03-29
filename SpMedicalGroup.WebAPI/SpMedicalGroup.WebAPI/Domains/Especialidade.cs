﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SpMedicalGroup.WebAPI.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medico>();
        }

        public byte IdEspecialidade { get; set; }
        public string Especialidade1 { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
