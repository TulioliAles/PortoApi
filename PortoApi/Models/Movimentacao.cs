using System;
using System.Collections.Generic;

#nullable disable

namespace PortoApi.Models
{
    public partial class Movimentacao
    {
        public int Id { get; set; }
        public string NumeroDeContainer { get; set; }
        public string Cliente { get; set; }
        public string Tipo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
