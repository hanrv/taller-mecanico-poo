using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14_09_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el modelo del vehículo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ingrese el color: ");
            string color = Console.ReadLine();

            Console.Write("Ingrese la matricula: ");
            string matricula = Console.ReadLine();

            Console.Write("Ingrese el nivel de combustible: ");
            int nivelCombustible = int.Parse(Console.ReadLine());

            Console.Write("Ingrese descripcion del problema: ");
            string descripcionProblema = Console.ReadLine();


            Vehiculo v1 = new Vehiculo(modelo, color, matricula, nivelCombustible, descripcionProblema);

            bool salir = false;
            while (!salir){
                Console.WriteLine("\n==============================");
                Console.WriteLine($" PANEL DE CONTROL: {modelo} [{matricula}]");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Mostrar reporte de estado");
                Console.WriteLine("2. Encender vehículo");
                Console.WriteLine("3. Apagar vehículo");
                Console.WriteLine("4. Acelerar");
                Console.WriteLine("5. Frenar");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción (1-6): ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        v1.mostrarReporte();
                        break;
                    case "2":
                        v1.encender();
                        v1.mostrarReporte();
                        break;
                    case "3":
                        v1.apagar();
                        v1.mostrarReporte();
                        break;
                    case "4":
                        v1.acelerar();
                        v1.mostrarReporte();
                        break;
                    case "5":
                        v1.frenar();
                        v1.mostrarReporte();
                        break;
                    case "6":
                        salir = true;
                        Console.WriteLine("Cerrando el panel de control...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }




            //Usuario usuario1 = new Usuario();
            //Usuario usuario2 = new Usuario("Bob");

            //Console.WriteLine($"Usuario 1: {usuario1.nombre}");
            //Console.WriteLine($"Usuario 2: {usuario2.nombre}");
        }
    }
}
