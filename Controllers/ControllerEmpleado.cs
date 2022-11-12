using PROYECTOCRUDPOOLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PROYECTOCRUDPOOLINQ.Controllers
{
    #region controllerie
    public class ControllerEmpleado
        
{

        public ControllerEmpleado()
        {

            _Empleados = new List<Empleados>();

        }
        #endregion controllere

        #region definelistae
        private List<Empleados> _Empleados;

        public List<Empleados> Empleados { get { return _Empleados; } }

        #endregion definelistae

        #region listadefaulte
        public void ListaBase()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                Id = 1,
                Nombre = "JUAN",
                Apellido = "PEREZ",
                Direccion = "CALLE 20",
                Telefono = "3006667788",
                FechaIngreso = DateTime.Parse("2010/01/01"),
                IdArea = 1
            });




            Empleados.Add(new Empleados()
            {
                Id = 2,
                Nombre = "ANA",
                Apellido = "CASTRO",
                Direccion = "CALLE 40",
                Telefono = "3026667788",
                FechaIngreso = DateTime.Parse("2011/02/01"),
                IdArea = 2
            });

        }
        #endregion lista defaulte

        #region metodose
        public void get()
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados select o);
            
            if (lista.Count > 0)
            {
                ImprimirEmpleados.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("[]");}
            
        }


        public void getbyId(int id)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.Id == id select o);
            
               if (lista.Count > 0)
              {
                  ImprimirEmpleados.Imprimir(lista);
              }
              else
              {
                  Console.WriteLine("No exite el Id " + id + " En nueestra BD");
              }
              
        }

        public void post(int id, string nombre, string apellido, string direccion, string telefono,
            DateTime fechai, int idarea)
        {

            var verificarId = Empleados.Any(i => i.Id == id);
            if (!verificarId)
            {

                Empleados.Add(new Empleados()
            {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Telefono = telefono,
                FechaIngreso = fechai,
                IdArea = idarea
            });

            Console.WriteLine("201");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }


        }


        public void update(int id, string nombre, string apellido, string direccion, string telefono,
            DateTime fechai, int idarea)
        {
            var ReplaceItem = new Empleados
            {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Telefono = telefono,
                FechaIngreso = fechai,
                IdArea = idarea
            };

            var element = Empleados.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            
            
            if (element != null)
            {
                Empleados.Remove(element);
                Empleados.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }




        }

        public void DeletexId(int id)
        {
            var EliminarItem = new Empleados { Id = id };
            var element = Empleados.FirstOrDefault(i => i.Id == id);
            
            if (element != null)
            {
                Empleados.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }



        }

        #endregion metodose


    }
}
