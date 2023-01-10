using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Camion
{
    public class CamionFrigorifico : Camion
    {
        public CamionFrigorifico(string modelo, string marca, int cantidadRuedas, double largo, double ancho, double temperatura) : base(modelo, marca, cantidadRuedas, largo, ancho)
        {
            Temperatura = temperatura;
        }
        public double Temperatura { get; set; }
    }
}
