using System;
using System.Collections.Generic;
using System.Text;

namespace Kit.Domain.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeLogin { get; set; }
        public int TipoUsuario { get; set; }
        public string Senha { get; set; }
        public string NomeUsuario { get; set; }
        public string CodigoCarteira { get; set; }
    }
}
