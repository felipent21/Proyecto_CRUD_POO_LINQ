using PROYECTOCRUDPOOLINQ.Controllers;
using System;
using System.Linq;

namespace PROYECTOCRUDPOOLINQ
{
    #region clase programs
    class Program
    {
        static void Main(string[] args)
        {

           
            
            Menus menus = new Menus();
            menus.MenuP();
            
        
       }
    }
    #endregion clase programs


    public class Menus
    {
        
        ControllerEmpleado CE = new ControllerEmpleado();
        ControllerArea CA = new ControllerArea();
        ControllerNomina CN = new ControllerNomina();

        #region menu principal
        public void MenuP() {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;


            int num=0;
           
            do
             
            {
                Console.Clear();
                Console.WriteLine("[ESTAS EN MENU PRINCIPAL]");
                Console.WriteLine("1.EMPLEADOS");
                Console.WriteLine("2.AREAS");
                Console.WriteLine("3.NOMINAS");
                Console.WriteLine("4.SALIR");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        MenuE();
                        break;
                    case 2:
                        MenuA();
                        break;
                    case 3:
                        MenuN();
                        break;
                    case 4:                        
                        Console.WriteLine("GRACIAS POR USAR NUESTRO PROGRAMA");                        
                        break;

                    default:
                        break;
                }
               
            }
            
            while (num != 4);

        }

        #endregion menu principal

        #region menu empleados
        public void MenuE()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            int id = 0;            
            string nombre = string.Empty;
            string apellido = string.Empty;
            string direccion = string.Empty;
            string telefono = string.Empty;
            DateTime fechai = DateTime.Now;
            int idarea = 0;
            CE.ListaBase();
            int num1;
            string des1;
            do
            {

                Console.Clear();
                Console.WriteLine("[ESTAS EN MENU EMPLEADOS]");
                Console.WriteLine("1. VER EMPLEADOS");
                Console.WriteLine("2. VER EMPLEADOS X ID");
                Console.WriteLine("3. AGREGAR EMPLEADOS");
                Console.WriteLine("4. MODIFICAR EMPLEADOS");
                Console.WriteLine("5. ELIMINAR EMPLEADOS X ID");
                Console.WriteLine("6. MENU PRINCIPAL");

                num1 = Convert.ToInt32(Console.ReadLine());
                switch (num1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("LISTADO DE EMPLEADOS");
                        CE.get();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("EMPLEADO X ID");
                        Console.WriteLine("INGRESA ID A BUSCAR");
                        id = Convert.ToInt32(Console.ReadLine());
                        CE.getbyId(id);

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("INSERTAR EMPLEADO");

                        Console.WriteLine("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduzca Nombre: ");
                        nombre = (Console.ReadLine());

                        Console.WriteLine("Introduzca Apellido: ");
                        nombre = (Console.ReadLine());

                        Console.WriteLine("Introduzca Direccion: ");
                        direccion = (Console.ReadLine());

                        Console.WriteLine("Introduzca Telefono: ");
                        telefono = (Console.ReadLine());

                        Console.WriteLine("Introduzca fecha: ");
                        fechai = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Introduzca Idarea: ");
                        idarea = Convert.ToInt32(Console.ReadLine());

                        CE.post(id, nombre, apellido, direccion, telefono, fechai, idarea);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("ACTUALIZAR EMPLEADO");
                        Console.WriteLine("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca Nombre: ");
                        nombre = (Console.ReadLine());

                        Console.WriteLine("Introduzca Apellido: ");
                        nombre = (Console.ReadLine());

                        Console.WriteLine("Introduzca Direccion: ");
                        direccion = (Console.ReadLine());

                        Console.WriteLine("Introduzca Telefono: ");
                        telefono = (Console.ReadLine());

                        Console.Write("Introduzca fecha: ");
                        fechai = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Introduzca Idarea: ");
                        idarea = Convert.ToInt32(Console.ReadLine());

                        CE.update(id, nombre, apellido, direccion, telefono, fechai, idarea);

                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("ELIMINAR EMPLEADO X ID");            
                        Console.WriteLine("INGRESA ID A ELIMINAR");
                        id = Convert.ToInt32(Console.ReadLine());
                        CE.DeletexId(id);                       

                        break;
                    case 6:

                        MenuP();

                        break;

                    default:
                        break;
                }
                Console.WriteLine("DESEAS VOLVER AL MENU EMPLEADOS SI/NO");
                des1 = Console.ReadLine();
            }
            while (des1 == "SI" || des1 == "si");
        }
        #endregion menu empleados

        #region menu areas

        public void MenuA() {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            int id = 0;
            string nombre = string.Empty;
            CA.ListaBase();
            int num2;
            string des2;
            do
            {

                Console.Clear();
                Console.WriteLine("[ESTAS EN MENU AREAS]");
                Console.WriteLine("1. VER AREAS");
                Console.WriteLine("2. VER AREAS X ID");
                Console.WriteLine("3. AGREGAR AREAS");
                Console.WriteLine("4. MODIFICAR AREAS");
                Console.WriteLine("5. ELIMINAR AREAS X ID");
                Console.WriteLine("6. MENU PRINCIPAL");

                num2 = Convert.ToInt32(Console.ReadLine());
                switch (num2)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("LISTADO DE AREAS");
                        CA.get();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("BUSCAR AREA POR ID");
                        Console.WriteLine("INGRESA ID A BUSCAR");
                        id = Convert.ToInt32(Console.ReadLine());
                        CA.getbyId(id);

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("INSERTAR AREAS");
                        Console.WriteLine("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca Nombre: ");
                        nombre = (Console.ReadLine());
                        CA.post(id, nombre);

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("ACTUALIZAR AREAS");
                        Console.WriteLine("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca Nombre: ");
                        nombre = (Console.ReadLine());
                        CA.update(id, nombre);

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("ELIMINAR AREAS XID");            
                        Console.WriteLine("INGRESA ID A ELIMINAR");
                        id = Convert.ToInt32(Console.ReadLine());
                        CA.DeletexId(id);

                        break;
                    case 6:

                        MenuP();

                        break;

                    default:
                        break;

                }
                Console.WriteLine("DESEAS VOLVER AL MENU AREAS SI/NO");
                des2 = Console.ReadLine();
            }
            while (des2 == "SI" || des2 == "si");
        }
        #endregion menu areas


        #region menu nominas
        public void MenuN() {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;

            int id = 0;
            DateTime fecha = DateTime.Now;
            int idempleado = 0;
            decimal sueldo = 0;
            int dias = 0;
            decimal basico = 0;
            decimal otros = 0;
            decimal devengado = 0;

            CN.ListaBase();       
          
          




            int num3;
            string des3;
            do
            {

                Console.Clear();
                Console.WriteLine("[ESTAS EN MENU NOMINAS]");
                Console.WriteLine("1. VER NOMINAS");
                Console.WriteLine("2. VER NOMINAS X ID");
                Console.WriteLine("3. AGREGAR NOMINA");
                Console.WriteLine("4. MODIFICAR NOMINA");
                Console.WriteLine("5. ELIMINAR NOMINA X ID");
                Console.WriteLine("6. MENU PRINCIPAL");

                num3 = Convert.ToInt32(Console.ReadLine());
                switch (num3)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("LISTADO NOMINAS");
                        CN.get();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("BUSCAR NOMINA X ID");
                        Console.WriteLine("INGRESA ID A BUSCAR");
                        id = Convert.ToInt32(Console.ReadLine());
                        CN.getbyId(id);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("INSERTAR NOMINA");
                        Console.WriteLine("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduzca fecha: ");
                        fecha = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Introduzca ID Empleado: ");
                        idempleado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduzca sueldo: ");
                        sueldo = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Introduzca dias ");
                        dias = Convert.ToInt32(Console.ReadLine());

                        CN.Calcularb(sueldo, dias);
                        basico= CN.Calcularb(sueldo, dias);

                        Console.WriteLine("Introduzca otros ingresos: ");
                        otros = Convert.ToDecimal(Console.ReadLine());

                        CN.Calculard(basico, otros);
                        devengado= CN.Calculard(basico, otros);

                        CN.post(id,fecha,idempleado,sueldo,dias,basico,otros,devengado);

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("ACTUALIZAR NOMINA");
                        Console.WriteLine("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduzca fecha: ");
                        fecha = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Introduzca ID Empleado: ");
                        idempleado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduzca sueldo: ");
                        sueldo = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Introduzca dias ");
                        dias = Convert.ToInt32(Console.ReadLine());

                        CN.Calcularb(sueldo, dias);
                        basico = CN.Calcularb(sueldo, dias);

                        Console.WriteLine("Introduzca otros: ");
                        otros = Convert.ToDecimal(Console.ReadLine());

                        CN.Calculard(basico, otros);
                        devengado = CN.Calculard(basico, otros);

                        CN.update(id, fecha, idempleado, sueldo, dias, basico, otros, devengado);
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("ELIMINAR NOMINA XID");            
                        Console.WriteLine("INGRESA ID A ELIMINAR");
                        id = Convert.ToInt32(Console.ReadLine());
                        CN.DeletexId(id);           

                        break;
                    case 6:

                        MenuP();

                        break;

                    default:
                        break;

                }
                Console.WriteLine("DESEAS VOLVER AL MENU NOMINAS SI/NO");
                des3 = Console.ReadLine();
            }
            while (des3 == "SI" || des3 == "si");

        }
        #endregion menu nominas


    }


}




    
