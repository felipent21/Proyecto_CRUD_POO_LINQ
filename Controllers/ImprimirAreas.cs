using PROYECTOCRUDPOOLINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTOCRUDPOOLINQ.Models
{
    public static class ImprimirAreas
    {

        public static void Imprimir(List<Areas> Area)
        { 

            foreach (var item in Area)
            {

                Console.WriteLine("Id:{0} Nombre:{1}",item.Id,item.Nombre);
            }
        }


    }
}
