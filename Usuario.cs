using System;
namespace ConsoleApp_14_09_2026
{
    internal class Usuario
    {
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }

        public Usuario(string nombre, string telefono)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del cliente es obligatorio.", "nombre");
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El teléfono del cliente es obligatorio.", "telefono");

            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
