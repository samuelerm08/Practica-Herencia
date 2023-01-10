using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Helicoptero
{
    public class HelicopteroMilitar : Helicoptero
    {
        public HelicopteroMilitar(string modelo, string marca, int cantPasajeros, int cantHelices, string destino, string pais) : base(modelo, marca, cantPasajeros, cantHelices, destino)
        {
            Pais = pais;
        }

        public string Pais { get; set; }
    }
}
