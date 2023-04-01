using System;
using System.Collections.Generic;

#nullable disable

namespace PortoApi.Models
{
    public partial class Container
    {
        public int Id { get; set; }
        public string NumeroDeSerie { get; set; }
        public string Cliente { get; set; }
        public int Tipo { get; set; }
        public string Status { get; set; }
        public string Categoria { get; set; }
    }
}
