using System;
using System.Collections.Generic;

namespace LLVG20240315.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            NumerosTelefonos = new List<NumerosTelefono>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }

        public virtual IList<NumerosTelefono> NumerosTelefonos { get; set; }
    }
}
