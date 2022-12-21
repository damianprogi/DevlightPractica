using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    internal class Auto
    {
        private string Modelo { get; set; }
        private string Marca { get; set; }
        private string Color { get; set; }
        private bool IsEncendido { get; set; }
        private int Velocidad { get; set; }
        private Persona? Conductor { get; set; }
        private int Capacidad { get; set; }
        private List<Pasajero> PasajerosList { get; set; }

        public Auto(string modelo, string marca, string color, int capacidad)
        {
            Modelo = modelo;
            Marca = marca;
            Color = color;
            IsEncendido = false;
            Velocidad = 0;
            Conductor = null;
            Capacidad = capacidad;
            PasajerosList = new List<Pasajero>();
        }

        public string Encender()
        {
            if (IsEncendido)
                return "El auto ya está encendido";

            if (IsConductor())
            {
                IsEncendido = true;
                return "Encendió: bruuuummmmmmmm brummmmm...";
            }
            return "El auto no enciende";
        }

        public string Apagar()
        {
            if (!IsEncendido)
                return "El auto está apagado! No puedes apagar si está apagado";

            Velocidad = 0;
            IsEncendido = false;
            return "*silencio... apagado";
        }

        public void Acelerar()
        {
            if (!IsEncendido) return;
            // modifiqué el punto para que si el auto no está en movimiento acelere 10un.
            Velocidad += (Velocidad == 0) ? 10 : (int)(Velocidad * 0.1);
        }

        public void Frenar()
        {
            if (!IsEncendido) return;
            // mofiqué el punto para que si el auto va a menos de 10un. de velocidad el auto al frenar se detenga.
            Velocidad -= (Velocidad < 8) ? Velocidad : (int)(Velocidad * 0.2);
        }

        public override string ToString()
        {
            return $"la velocidad del auto es {Velocidad}; el estado es: {IsEncendido}";
        }

        public bool SubirConductor(Persona persona)
        {
            if (persona != null)
            {
                Conductor = persona;
                return true;
            }
            return false;
        }

        public bool IsConductor()
        {
            return (Conductor != null && Conductor.Edad() >= 18) ? true : false;
        }

        public bool SubirPasajeros(Pasajero pasajero)
        {
            // menos uno a la capacidad porque resto conductor
            if (PasajerosList.Count < Capacidad - 1)
            {
                PasajerosList.Add(pasajero);
                return true;
            }
            return false;
        }

        public bool SubirMascota(Mascota mascota)
        {
            bool isBig = mascota.IsGrande();
            bool volvio = false;

            if (isBig)
                volvio = SubirPasajeros(mascota);
            else
            {
                int index = 0;
                if (PasajerosList != null)
                    do
                    {
                        if (PasajerosList[index] != null)
                        {
                            Pasajero p = PasajerosList[index];
                            if (p != null && typeof(Persona).IsInstanceOfType(p))
                            {
                                Persona per = p as Persona;
                                volvio = per.SubirMascotaEnRegazo(mascota);
                            }
                            if (volvio) break;
                        }
                        index += 1;
                        //Console.WriteLine(index);
                        //Console.WriteLine("aca: " + (PasajerosList.Count > index));
                    } while (PasajerosList.Count > index);
            }

            Console.WriteLine("mascota es grande?: " + isBig);
            return volvio;
        }

        public void HayMascotasEnRegazo()
        {
            PasajerosList?.ForEach(
                pasajero =>
                {
                    if (pasajero != null && typeof(Persona).IsInstanceOfType(pasajero))
                    {
                        Persona persona = pasajero as Persona;
                        Console.WriteLine(persona.MencionarMascotaEnRegazo());
                    }
                });
        }

        public bool MoverMascotaAOtroRegazo(Persona personaOrigen, Persona personaDestino)
        {
            if ((personaDestino.getMascotaRegazo() == null) && (personaOrigen.getMascotaRegazo != null))
            {
                Mascota mascota = personaOrigen.getMascotaRegazo();
                personaDestino.setMascotaRegazo(mascota);
                personaOrigen.setMascotaRegazo(null);
            }
            return true;
        }

        public bool BajarTodosDelAuto()
        {
            if (DetenerAuto())
                Apagar();

            if (IsEncendido)
                return false;

            if (BajarPasajeros())
            {
                Console.WriteLine("se baja el conductor: " + Conductor?.ToString());
                Conductor = null;
            }
            else
                return false;

            return true;
        }

        private bool DetenerAuto()
        {
            while (Velocidad > 0)
                Frenar();

            return true;
        }

        private bool BajarPasajeros()
        {
            while (PasajerosList.Count != 0)
            {
                if (PasajerosList[0] != null)
                {
                    Console.WriteLine(PasajerosList[0].ToString() + " se bajó ");
                    PasajerosList.RemoveAt(0);
                }
            }
            return true;
        }

    }
}
