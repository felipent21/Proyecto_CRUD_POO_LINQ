using PROYECTOCRUDPOOLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PROYECTOCRUDPOOLINQ.Controllers
{
    public class ControllerArea
    {
        #region controllera
        public ControllerArea()
        {

            _Areas = new List<Areas>();

        }
        #endregion controllera

        #region definelistaa
        private List<Areas> _Areas;

        public List<Areas> Areas { get { return _Areas; } }

        #endregion definelistaa

        #region listadefaulta
        public void ListaBase()
        {
            Areas.Clear();
            Areas.Add(new Areas()
            {
                Id = 1,
                Nombre = "FINANZAS"
                
                
            });

            Areas.Add(new Areas()
            {
                Id = 2,
                Nombre = "INVESTIGACION"
                
            });

        }
#endregion listadefaulta
        #region metodosa
        public void get()
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas select o);
            
            if (lista.Count > 0)
            {
                ImprimirAreas.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }
        }


        public void getbyId(int id)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.Id == id select o);

            if (lista.Count > 0)
            {
                ImprimirAreas.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nueestra BD");
            }

            
        }

        public void post(int id, string nombre
          )
        {

            var verificarId = Areas.Any(i => i.Id == id);
            if (!verificarId)
            {
                Areas.Add(new Areas()
            {
                Id = id,
                Nombre = nombre
                
            });
            Console.WriteLine("201");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }



        }


        public void update(int id, string nombre
        )
        {
            var ReplaceItem = new Areas
            {
                Id = id,
                Nombre = nombre,
                
            };

            var element = Areas.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            
            
            if (element != null)
            {
                Areas.Remove(element);
                Areas.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }




        }

        public void DeletexId(int id)
        {
            var EliminarItem = new Areas { Id = id };
            var element = Areas.FirstOrDefault(i => i.Id == id);
            
            if (element != null)
            {
                Areas.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }


        }
        #endregion metodosa


    }
}
