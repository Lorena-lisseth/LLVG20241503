using System;
using System.Collections.Generic;

namespace LLVG20240315.Models
{
    public partial class NumerosTelefono
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public string? Telefono { get; set; }
        public string? TipoTelefono { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
    }
}
