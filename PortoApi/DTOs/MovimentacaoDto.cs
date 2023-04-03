using System;

namespace PortoApi.DTOs
{
    public class MovimentacaoDto
    {
        public string NumeroDeContainer { get; set; }
        public string Tipo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
