using LibreriaHerencia.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Avion
{
    public abstract class Avion : AereoBase
    {
        public Avion(string modelo, string marca, int cantPasajeros, int cantidadMotores) : base(modelo, marca, cantPasajeros)
        {
            CantidadMotores = cantidadMotores;
        }

        public int CantidadMotores { get; set; }
    }
}
