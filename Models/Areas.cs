using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PROYECTOCRUDPOOLINQ.Models
{
    public class Areas
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "CAMPO NECESARIO")]
        public string Nombre { get; set; }

    }
}
