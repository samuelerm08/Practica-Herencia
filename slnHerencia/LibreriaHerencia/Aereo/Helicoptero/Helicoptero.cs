using LibreriaHerencia.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Helicoptero
{
    public abstract class Helicoptero : AereoBase
    {
        public Helicoptero(string modelo, string marca, int cantPasajeros, int cantHelices, string destino) : base(modelo, marca, cantPasajeros)
        {
            CantHelices = cantHelices;
            Destino = destino;
        }
        public int CantHelices { get; set; }
        public string Destino { get; set; }

    }
}
