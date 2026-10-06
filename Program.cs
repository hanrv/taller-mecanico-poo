using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp_14_09_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Reparacion> reparaciones = new List<Reparacion>();
            int siguienteNumeroTicket = 1;
            bool salir = false;

            Console.WriteLine("Taller mecánico \"El Rápido\"");
            Console.WriteLine("Registro y consulta de tickets de reparación.\n");

            while (!salir)
            {
                Console.WriteLine("1. Registrar una reparación");
                Console.WriteLine("2. Consultar un ticket");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        RegistrarReparacion(reparaciones, siguienteNumeroTicket);
                        siguienteNumeroTicket++;
                        break;
                    case "2":
                        ConsultarReparacion(reparaciones);
                        break;
                    case "3":
                        salir = true;
                        Console.WriteLine("Gracias por utilizar el sistema de El Rápido.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Seleccione 1, 2 o 3.\n");
                        break;
                }
            }
        }

        private static void RegistrarReparacion(List<Reparacion> reparaciones, int numeroTicket)
        {
            Console.WriteLine("\n--- Datos del cliente ---");
            string nombre = LeerTexto("Nombre: ");
            string telefono = LeerTexto("Teléfono de contacto: ");

            Console.WriteLine("\n--- Datos del vehículo ---");
            string marca = LeerTexto("Marca: ");
            string modelo = LeerTexto("Modelo: ");
            string color = LeerTexto("Color: ");
            string matricula = LeerTexto("Matrícula: ");
            double nivelCombustible = LeerNivelCombustible();
            string descripcionAveria = LeerTexto("Describa la avería: ");

            Usuario cliente = new Usuario(nombre, telefono);
            Vehiculo vehiculo = new Vehiculo(marca, modelo, color, matricula, nivelCombustible);
            Reparacion reparacion = new Reparacion(numeroTicket, cliente, vehiculo, descripcionAveria);
            reparaciones.Add(reparacion);

            Console.WriteLine("\nSolicitud registrada. Su número de ticket es: {0}\n", reparacion.NumeroTicket);
        }

        private static void ConsultarReparacion(List<Reparacion> reparaciones)
        {
            if (reparaciones.Count == 0)
            {
                Console.WriteLine("Todavía no hay tickets registrados.\n");
                return;
            }

            Console.Write("Introduzca el número de ticket: ");
            int numeroTicket;
            if (!int.TryParse(Console.ReadLine(), out numeroTicket))
            {
                Console.WriteLine("El número de ticket no es válido.\n");
                return;
            }

            Reparacion reparacion = reparaciones.FirstOrDefault(r => r.NumeroTicket == numeroTicket);
            if (reparacion == null)
            {
                Console.WriteLine("No se encontró un ticket con ese número.\n");
                return;
            }

            Console.WriteLine();
            reparacion.MostrarDetalle();
            Console.WriteLine();
        }

        private static string LeerTexto(string mensaje)
        {
            string valor;
            do
            {
                Console.Write(mensaje);
                valor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(valor))
                    Console.WriteLine("Este dato es obligatorio.");
            }
            while (string.IsNullOrWhiteSpace(valor));

            return valor.Trim();
        }

        private static double LeerNivelCombustible()
        {
            double nivel;
            while (true)
            {
                Console.Write("Nivel de combustible (0-100 %): ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, NumberStyles.Number, CultureInfo.CurrentCulture, out nivel) && nivel >= 0 && nivel <= 100)
                    return nivel;

                Console.WriteLine("Introduzca un número entre 0 y 100.");
            }
        }
    }
}
