using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROYECTOCRUDPOOLINQ.Models
{
    public class  Nominas
    {

        [Key]
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        [ForeignKey("IdEmpleado")]
        public int IdEmpleado { get; set; }

        public decimal Sueldo { get; set; }

        public int Dias { get; set; }       

        public decimal TotalBasico { get; set; }

        public decimal Otros { get; set; }

        public decimal Devengado { get; set; }



    }
}
