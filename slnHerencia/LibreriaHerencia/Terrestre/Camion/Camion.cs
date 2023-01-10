using LibreriaHerencia.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Camion
{
    public abstract class Camion : TerrestreBase
    {
        public Camion(string modelo, string marca, int cantidadRuedas, double largo, double ancho) : base(modelo, marca, cantidadRuedas)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double Ancho { get; set; }
        public double Largo { get; set; }
    }
}
