using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14_09_2026
{
    internal class Usuario
    {
        public string nombre { get; set; }
        public int edad { get; set; }

        public Usuario(string nombre = "Guest")
        {
            this.nombre = nombre;
        }

        public void ModificarEdad(int nuevaEdad)
        {
            edad = nuevaEdad;
        }

        public void CumplirAnios()
        {
            edad++;
        }
    }
}
