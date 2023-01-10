using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Auto
{
    public class AutoUrbano : Auto
    {
        public AutoUrbano(string modelo, string marca, int cantidadRuedas, int cantPuertas, int kilometrosRecorridos) : base(modelo, marca, cantidadRuedas, cantPuertas)
        {
            KilometrosRecorridos = kilometrosRecorridos;
        }
        public int KilometrosRecorridos { get; set; }
    }
}
