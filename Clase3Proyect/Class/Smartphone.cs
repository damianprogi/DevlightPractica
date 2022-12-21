using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    internal class Smartphone
    {
        //a.para encender y apagar el mismo,
        //b. subir y bajar el volumen,
        //c. poner en silencio,
        //d. bajar o subir el brillo de la pantalla.
        //e. Además de properties para marca y modelo.

        private bool IsEncendido { get; set; }
        private int Volumen { get; set; }
        private bool IsMuted { get; set; }
        private int Brillo { get; set; }
        private string Marca { get; set; }
        private string Modelo { get; set; }
        public Smartphone(string marca, string modelo)
        {
            IsEncendido = true;
            Volumen = 50;
            IsMuted = false;
            Brillo = 100;
            Marca = marca;
            Modelo = modelo;
        }

        public void EncendidoApagado()
        {
            IsEncendido = !IsEncendido;
        }

        public void SubirVolumen()
        {
            if (IsEncendido)
                Volumen = CambiarVolumen(10);
        }
        public void BajarVolumen()
        {
            if (IsEncendido)
                Volumen = CambiarVolumen(-10);
        }

        private int CambiarVolumen(int volumen)
        {
            if (volumen > 0)
                return ((100 - Volumen) > volumen) ? (volumen + Volumen) : 100;

            return ((Volumen + volumen) > 0) ? (volumen + Volumen) : 0;
        }

        public void Silenciar()
        {
            if (IsEncendido)
                IsMuted = !IsMuted;
        }

        public void SubirBrillo()
        {
            if (IsEncendido)
                Brillo = CambiarBrillo(10);
        }
        public void BajarBrillo()
        {
            if (IsEncendido)
                Brillo = CambiarBrillo(-10);
        }

        private int CambiarBrillo(int brillo)
        {
            if (brillo > 0)
                return ((100 - Brillo) > brillo) ? (brillo + Brillo) : 100;

            return ((Brillo + brillo) > 0) ? (brillo + Brillo) : 0;
        }

        public override string ToString()
        {
            string texto = $"El telefono es un {Marca} modelo {Modelo}: encendido: {IsEncendido}, volumen:{Volumen}, muted:{IsMuted}, brillo:{Brillo}";
            return (texto);
        }


    }
}
