using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    internal class TipoMascota
    {
        private int grande = 15;
        private string Tipo { get; set; }
        private int Tamano { get; set; }

        public TipoMascota (string tipo, int tamano)
        {
            if (tipo == "gato" || tipo == "perro")
            {
                Tipo = tipo;
                Tamano = tamano;
            }
            else
                throw new Exception("No es perro ni gato, no se creo el tipo");
        }

        public bool IsGrande()
        {
            if (Tamano > grande)
                return true;
            return false;
        }

        public string GetTipo()
        {
            return Tipo;
        }

        public override string ToString()
        {
            string textTamano = (IsGrande()) ? "grande" : "pequeño";
            return $"{Tipo} {textTamano}";
        }
    }
}
