using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LLVG20240315.Models
{
    public partial class NumerosTelefono
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
     
        public string? Telefono { get; set; }

        [Display(Name = "Tipo de Telefono")]
        public string? TipoTelefono { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
    }
}
