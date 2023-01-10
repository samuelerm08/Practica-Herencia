using LibreriaHerencia.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Zeppellin
{
    public class Zeppellin : AereoBase
    {
        public Zeppellin(string modelo, string marca, int cantPasajeros, string clasificacion) : base(modelo, marca, cantPasajeros)
        {
            Clasificacion = clasificacion;
        }

        //Pueden ser rigidos, semirigidos y no-rigidos
        public string Clasificacion { get; set; }
    }
}
