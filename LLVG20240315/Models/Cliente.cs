using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LLVG20240315.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            NumerosTelefonos = new List<NumerosTelefono>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Es necesario ingresar el nombre")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Es necesario ingresar la dirección")]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "Es necesario ingresar la dirección")]
        public string? Correo { get; set; }

        public virtual IList<NumerosTelefono> NumerosTelefonos { get; set; }
    }
}
