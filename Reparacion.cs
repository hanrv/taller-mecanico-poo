using System;

namespace ConsoleApp_14_09_2026
{
    internal class Reparacion
    {
        public int NumeroTicket { get; private set; }
        public Usuario Cliente { get; private set; }
        public Vehiculo Vehiculo { get; private set; }
        public string DescripcionAveria { get; private set; }
        public string Estado { get; private set; }
        public DateTime FechaIngreso { get; private set; }

        public Reparacion(int numeroTicket, Usuario cliente, Vehiculo vehiculo, string descripcionAveria)
        {
            if (numeroTicket <= 0)
                throw new ArgumentOutOfRangeException("numeroTicket", "El número de ticket debe ser mayor que cero.");
            if (cliente == null)
                throw new ArgumentNullException("cliente");
            if (vehiculo == null)
                throw new ArgumentNullException("vehiculo");
            if (string.IsNullOrWhiteSpace(descripcionAveria))
                throw new ArgumentException("La descripción de la avería es obligatoria.", "descripcionAveria");

            NumeroTicket = numeroTicket;
            Cliente = cliente;
            Vehiculo = vehiculo;
            DescripcionAveria = descripcionAveria;
            Estado = "Recibida: pendiente de revisión";
            FechaIngreso = DateTime.Now;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine("--- Ticket de reparación #{0} ---", NumeroTicket);
            Console.WriteLine("Fecha de ingreso: {0:dd/MM/yyyy HH:mm}", FechaIngreso);
            Console.WriteLine("Cliente: {0}", Cliente.Nombre);
            Console.WriteLine("Teléfono: {0}", Cliente.Telefono);
            Console.WriteLine("Avería descrita: {0}", DescripcionAveria);
            Console.WriteLine("Estado: {0}", Estado);
            Vehiculo.MostrarReporte();
        }
    }
}
