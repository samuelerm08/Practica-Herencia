using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Avion
{
    public class Avioneta : Avion
    {
        public Avioneta(string modelo, string marca, int cantPasajeros, int cantidadMotores, string propietario) : base(modelo, marca, cantPasajeros, cantidadMotores)
        {
            Propietario = propietario;
        }
        public string Propietario { get; set; }
    }
}
