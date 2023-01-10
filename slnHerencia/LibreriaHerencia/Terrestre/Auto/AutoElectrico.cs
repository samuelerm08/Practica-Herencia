using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Auto
{
    public class AutoElectrico : Auto
    {
        public AutoElectrico(string modelo, string marca, int cantidadRuedas, int cantPuertas, int voltaje) : base(modelo, marca, cantidadRuedas, cantPuertas)
        {
            Voltaje = voltaje;
        }

        public int Voltaje { get; set; }
    }
}
