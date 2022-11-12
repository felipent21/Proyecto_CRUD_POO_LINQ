using PROYECTOCRUDPOOLINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTOCRUDPOOLINQ.Controllers
{
    public static class ImprimirNominas
    {
        public static void Imprimir(List<Nominas> Nomina)
        {
            foreach (var item in Nomina)
            {

                Console.WriteLine("Id:{0} Fecha:{1} Idemple:{2} " +
                 "Sueldo:{3} Dias:{4} TBasico:{5} Otros:{6} Deven:{7} ",item.Id,
                    item.Fecha, item.IdEmpleado,item.Sueldo, item.Dias, item.TotalBasico,
                    item.Otros, item.Devengado);
            }
        }



    }
}
