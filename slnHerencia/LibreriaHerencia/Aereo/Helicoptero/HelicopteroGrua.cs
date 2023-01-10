using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Helicoptero
{
    public class HelicopteroGrua : Helicoptero
    {
        public HelicopteroGrua(string modelo, string marca, int cantPasajeros, int cantHelices, string destino, double capacidad) : base(modelo, marca, cantPasajeros, cantHelices, destino)
        {
            Capacidad = capacidad;
        }
        public double Capacidad { get; set; }
    }
}
