using System;
namespace ConsoleApp_14_09_2026
{
    internal class Vehiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Color { get; private set; }
        public string Matricula { get; private set; }
        public double NivelCombustible { get; private set; }
        public bool EstaEncendido { get; private set; }
        public int Velocidad { get; private set; }

        public Vehiculo(string marca, string modelo, string color, string matricula, double nivelCombustible)
        {
            if (string.IsNullOrWhiteSpace(marca))
                throw new ArgumentException("La marca es obligatoria.", "marca");
            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("El modelo es obligatorio.", "modelo");
            if (string.IsNullOrWhiteSpace(color))
                throw new ArgumentException("El color es obligatorio.", "color");
            if (string.IsNullOrWhiteSpace(matricula))
                throw new ArgumentException("La matrícula es obligatoria.", "matricula");
            if (nivelCombustible < 0 || nivelCombustible > 100)
                throw new ArgumentOutOfRangeException("nivelCombustible", "El combustible debe estar entre 0 y 100 %.");

            Marca = marca;
            Modelo = modelo;
            Color = color;
            Matricula = matricula;
            NivelCombustible = nivelCombustible;
            EstaEncendido = false;
            Velocidad = 0;
        }

        public void MostrarReporte()
        {
            Console.WriteLine("--- Estado del vehículo ---");
            Console.WriteLine("Marca: {0}", Marca);
            Console.WriteLine("Modelo: {0}", Modelo);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Matrícula: {0}", Matricula);
            Console.WriteLine("Combustible: {0}%", NivelCombustible);
            Console.WriteLine("Motor encendido: {0}", EstaEncendido ? "Sí" : "No");
            Console.WriteLine("Velocidad: {0} km/h", Velocidad);
        }

        public void Encender()
        {
            if (NivelCombustible <= 0)
                throw new InvalidOperationException("No se puede encender el vehículo sin combustible.");

            EstaEncendido = true;
        }

        public void Apagar()
        {
            if (Velocidad > 0)
                throw new InvalidOperationException("No se puede apagar el motor mientras el vehículo está en movimiento.");

            EstaEncendido = false;
        }

        public void Acelerar(int incremento)
        {
            if (!EstaEncendido)
                throw new InvalidOperationException("Es necesario encender el motor antes de acelerar.");
            if (incremento <= 0)
                throw new ArgumentOutOfRangeException("incremento", "El incremento debe ser mayor que cero.");

            Velocidad += incremento;
        }

        public void Frenar()
        {
            Velocidad = 0;
        }
    }
}
