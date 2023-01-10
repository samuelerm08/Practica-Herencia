using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Avion
{
    public class AvionComercial : Avion
    {
        public AvionComercial(string modelo, string marca, int cantPasajeros, int cantidadMotores, string aerolinea) : base(modelo, marca, cantPasajeros, cantidadMotores)
        {
            Aerolinea = aerolinea;
        }
        public string Aerolinea { get; set; }
    }
}
