using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    internal class Estudiante : Persona
    {
        private List<Libro> ListaLibros { get; set; } = new List<Libro>();

        public Estudiante(string nombre, string apellido) : base(nombre, apellido)
        {
        }

        public Estudiante(string nombre, string apellido, DateTime fechaNacimiento) : base(nombre, apellido, fechaNacimiento)
        {
        }

        public void AddLibro(Libro libro)
        {
            //if (ListaLibros is null) ListaLibros = new List<Libro>();
            ListaLibros.Add(libro);
        }

        public void RemoveUltimoLibro()
        {
            if (ListaLibros.Count > 0)
                ListaLibros.RemoveAt(0);
        }
        public void LibrosLeidos()
        {
            if (ListaLibros.Count > 0)
            {
                List<Libro> librosLeidos = ListaLibros.FindAll(x => x.getWasRead());
                if (librosLeidos.Count > 0)
                    librosLeidos.ForEach(libro => { Console.WriteLine(libro.ToString()); });
                else
                    Console.WriteLine("Todavía no leiste los libros que tienes");
            }
            else
            {
                Console.WriteLine("no hay libros leidos");
            }
        }
        public void LibrosSinLeidos()
        {
            if (ListaLibros.Count > 0)
            {
                List<Libro> librosLeidos = ListaLibros.FindAll(x => !x.getWasRead());
                librosLeidos.ForEach(libro => { Console.WriteLine(libro.ToString()); });
            }
            else
            {
                Console.WriteLine("no hay libros sin ser leidos");
            }
        }
        public void CantLibrosSinLeer()
        {
            if (ListaLibros.Count > 0)
            {
                int count = ListaLibros.FindAll(x => !x.getWasRead()).Count();
                Console.WriteLine("Se leyeron" + count);
            }
            else
            {
                Console.WriteLine("no se leyeron libros");
            }
        }
        public void CantPáginasLeidas()
        {
            int count = 0;
            if (ListaLibros.Count > 0)
            {
                List<Libro> librosLeidos = ListaLibros.FindAll(x => x.getWasRead());
                foreach (var libro in librosLeidos)
                {
                    count += libro.getCantPaginasLeidas();
                }
            }
            Console.WriteLine("leyó " + count + " páginas.");
        }




    }
}
