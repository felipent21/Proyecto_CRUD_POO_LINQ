using PROYECTOCRUDPOOLINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTOCRUDPOOLINQ.Models
{
    public static class ImprimirEmpleados
    {

        public static void Imprimir(List<Empleados> Empleado)
        {
            foreach (var item in Empleado){
                
                Console.WriteLine("Id:{0} Nombre:{1} Apellido:{2} " +
                 "Dir:{3} Tel:{4} FechaIng:{5} IdArea:{6} ", item.Id,
                    item.Nombre, item.Apellido, item.Direccion, item.Telefono,
                    item.FechaIngreso,item.IdArea);
            }
        }
    }
}
