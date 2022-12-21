using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    internal class Pasajero
    {
        private string Nombre { get; set; }

        public Pasajero(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre.ToString();
        }
    }
}
