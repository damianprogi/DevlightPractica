using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    internal class Mascota : Pasajero
    {
        //public enum TipoMascota
        //{
        //    gato,
        //    perro
        //}

        //private TipoMascota Tipo { get; set;}

        //public Mascota(string nombre, TipoMascota tipo )
        //{
        //    Nombre = nombre;
        //    Tipo = tipo;
        //    Energia = 50;
        //}

        //private string Nombre { get; set; }
        private int Energia { get; set; }
        private TipoMascota Tipo { get; set; }

        public Mascota(string nombre, TipoMascota tipo): base (nombre)
        {
            Tipo = tipo;
            Energia = 50;
        }

        public bool IsGrande()
        {
            return Tipo.IsGrande();
        }


        public void Alimentar()
        {
            Energia = (int)(Energia * 1.3);

            if (Energia > 100)
                Energia = 100;
            Console.WriteLine(Energia.ToString());
        }

        public void Correr()
        {
            if (Energia > 20)
            {
                Energia -= 10;
                Console.WriteLine("tu {0} corrió y quedó con {1} energia", Tipo, Energia);
            }
        }

        public override string ToString()
        {
            return $"La mascota se llama {base.ToString()}, y es un {Tipo.ToString()} que tiene {Energia} de energia";
        }

        public string NombreMascota()
        {
            return base.ToString();
        }



    }
}

