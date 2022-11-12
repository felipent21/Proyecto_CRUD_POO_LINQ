using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROYECTOCRUDPOOLINQ.Models
{
    public class Empleados
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "CAMPO NECESARIO")]
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaIngreso { get; set; }
        
        [ForeignKey("IdArea")]
        public int IdArea { get; set; }


    }
}
