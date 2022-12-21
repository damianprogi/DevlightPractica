using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    //Crear una clase Libro, que contenga Nombre, Autor, Cantidad de Páginas, y
    //una property llamada WasRead, que diga si el libro fue leído o no (boolean).
    internal class Libro
    {
        private string Nombre { get; set; }
        private string Autor { get; set; }
        private int CantPaginas { get; set; }
        private bool WasRead { get; set; }

        public Libro(string nombre, string autor, int cantPaginas)
        {
            Nombre = nombre;
            Autor = autor;
            CantPaginas = cantPaginas;
            WasRead = false;
        }

        public bool getWasRead()
        {
            return WasRead;
        }

        public int getCantPaginasLeidas()
        {
            return CantPaginas;
        }

        public override string ToString()
        {
            return $"El libro es {Nombre} de {Autor} con {CantPaginas} páginas";
        }
    }
}
