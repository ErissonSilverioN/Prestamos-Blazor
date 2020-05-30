using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Prestamos_Blazor.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public int PersonaId { get; set; }
        public string Persona { get; set; }

        [Required (ErrorMessage ="Esta Campo es Obligatorio")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Esta Campo es Obligatorio")]
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }
        public DateTime Fecha { get; set; }
    }
}
