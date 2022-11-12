using PROYECTOCRUDPOOLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROYECTOCRUDPOOLINQ.Controllers
{
    #region controllern
    public class ControllerNomina :Nominas
    {
        Nominas nomina = new Nominas();

        public ControllerNomina()
        {

            _Nominas = new List<Nominas>();

        }
        #endregion controllern
        #region define listasn

        private List<Nominas> _Nominas;

        public List<Nominas> Nominas { get { return _Nominas; } }

        #endregion define listasn

        #region lista basen
        public void ListaBase()
        {
            
            Nominas.Clear();
            Nominas.Add(new Nominas()
            {
                Id = 1,
                Fecha = DateTime.Parse("2010/01/01"),
                IdEmpleado = 2,
                Sueldo = 2000000,
                Dias = 30,            
                TotalBasico = (nomina.Sueldo *nomina.Dias) / 30,
                Otros = 500000,
                Devengado = (nomina.TotalBasico + nomina.Otros)

            }) ;


            Nominas.Add(new Nominas()
            {
                Id = 2,
                Fecha = DateTime.Parse("2010/01/01"),
                IdEmpleado = 2,
                Sueldo = 2000000,
                Dias = 30,
                TotalBasico = (nomina.Sueldo * nomina.Dias) / 30,
                Otros = 500000,
                Devengado = (nomina.TotalBasico + nomina.Otros)
                
            }) ;


        }
        #endregion lista basen

        #region metodosn
        public void get()
        {
            
            List<Nominas> lista = new List<Nominas>();
            lista.AddRange(from o in Nominas select o);
            
            if (lista.Count > 0)
            {
                ImprimirNominas.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }


        }


        public void getbyId(int id)
        {
            List<Nominas> lista = new List<Nominas>();
            lista.AddRange(from o in Nominas where o.Id == id select o);
            
            if (lista.Count > 0)
            {
                ImprimirNominas.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " En nueestra BD");
            }


        }

        public void post(int id, DateTime fecha, int idempleado,decimal sueldo,
            int dias,decimal basico,decimal otros,decimal devengado)
            
        {
            var verificarId = Nominas.Any(i => i.Id == id);
            if (!verificarId)
            {

                Nominas.Add(new Nominas()
            {
                Id = id,
                Fecha = fecha,
                IdEmpleado = idempleado,
                Sueldo = sueldo,
                Dias = dias,
                TotalBasico = basico,
                Otros = otros,
                Devengado = devengado
            });
            Console.WriteLine("201");

            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }
        }


        public void update(int id, DateTime fecha, int idempleado, decimal sueldo,
            int dias,decimal basico, decimal otros,decimal devengado)
        {
            var ReplaceItem = new Nominas
            {
                Id = id,
                Fecha = fecha,
                IdEmpleado = idempleado,
                Sueldo = sueldo,
                Dias = dias,
                TotalBasico = basico,                
                Otros = otros,
                Devengado = devengado
            };

            var element = Nominas.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            
            
            if (element != null)
            {
                Nominas.Remove(element);
                Nominas.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }


        }

        public void DeletexId(int id)
        {
            var EliminarItem = new Nominas { Id = id };
            var element = Nominas.FirstOrDefault(i => i.Id == id);
            
            if (element != null)
            {
                Nominas.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }


        }



        public decimal Calcularb(decimal sueldo, int dias) { 
        
        decimal basico = (sueldo*dias)/30;

        return basico;
        
        
        }

        public decimal Calculard(decimal basico, decimal otros) {

            decimal devengado = basico + otros;

            return devengado;
        }

        #endregion metodosn
    }
}
