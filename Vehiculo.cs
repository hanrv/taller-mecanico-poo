using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14_09_2026
{
    internal class Vehiculo
    {
        public string modelo { get; set; }
        public string color { get; set; }
        public string matricula { get; set; }
        public double nivelCombustible { get; set; }
        public string descripcionProblema { get; set; }
        public bool estaEncendido { get; private set; }
        public int velocidad { get; private set; }

        public Vehiculo(string modelo, string color, string matricula, double nivelCombustible, string descripcionProblema)
        {
            this.modelo = modelo;
            this.color = color;
            this.matricula = matricula;
            this.nivelCombustible = nivelCombustible;
            this.descripcionProblema = descripcionProblema;
            this.estaEncendido = false;
            this.velocidad = 0;
        }

        public void mostrarReporte()
        {
            Console.WriteLine("++Reporte del Vehiculo++");
            Console.WriteLine($"Modelo {modelo}");
            Console.WriteLine($"Color {color}");
            Console.WriteLine($"Matricula {matricula}");
            Console.WriteLine($"Nivel combustible: {nivelCombustible}%");
            Console.WriteLine($"Descripcion del problema: {descripcionProblema}");
            string estado = ((estaEncendido == true) ? "Si" : "No");
            Console.WriteLine($"Esta encendido: {estado}");
            Console.WriteLine($"Velocidad actual: {velocidad}\n");
        }
        public void encender()
        {
            estaEncendido = true;
        }
        public void apagar()
        {
            estaEncendido = false;
        }

        public void acelerar()
        {
            velocidad += 10;
        }
        public void frenar()
        {
            velocidad = 0;
        }
    }
}
