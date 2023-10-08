using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wsApi.Models
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int personaId { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public string Email { get; set; }
    }
}
