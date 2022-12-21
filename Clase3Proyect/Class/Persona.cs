using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase3Proyect.Class
{
    internal class Persona : Pasajero
    {
        //private string Nombre { get; set; }
        private string Apellido { get; set; }
        private Smartphone? Telefono { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private Mascota? InRegazo { get; set; }

        public Persona(string nombre, string apellido) : base(nombre)
        {
            //Nombre = nombre;
            Apellido = apellido;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento) : base(nombre)
        {
            //Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;

        }

        public string NombreCompleto()
        {
            return base.ToString() + ' ' + Apellido;
        }

        public int Edad()
        {
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Today - FechaNacimiento;
            DateTime edad = new DateTime(ts.Ticks);
            return edad.Year - 1;
        }

        public bool AdquirirSmartPhone(Smartphone tel)
        {
            if (Telefono == null)
            {
                Telefono = tel;
                return true;
            }

            return false;
        }

        public Mascota? getMascotaRegazo()
        {
            return InRegazo;
        }

        public void setMascotaRegazo(Mascota? mascota)
        {
            InRegazo = mascota;
        }

        public bool SubirMascotaEnRegazo(Mascota mascota)
        {
            //Console.WriteLine("este regazo está: " + InRegazo + " tipo: " + (InRegazo is null));
            if (InRegazo == null)
            {
                InRegazo = mascota;
                return true;
            }
            return false;
        }

        public string MencionarMascotaEnRegazo()
        {
            if (InRegazo != null)
                return $"{this.NombreCompleto()} tiene la mascota {InRegazo.NombreMascota()} en su regazo";
            return $"{this.NombreCompleto()} no tiene mascota en su regazo";
        }



    }

}






