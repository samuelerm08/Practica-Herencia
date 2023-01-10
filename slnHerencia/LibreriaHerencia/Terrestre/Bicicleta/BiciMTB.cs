using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Bicicleta
{
    public class BiciMTB : Bicicleta
    {
        public BiciMTB(string modelo, string marca, int cantidadRuedas, int rodado, bool amortiguador) : base(modelo, marca, cantidadRuedas, rodado)
        {
            Amortiguador = amortiguador;
        }

        public bool Amortiguador { get; set; }
    }
}
