using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Auto
{
    public class AutoFormulaUno : Auto
    {
        public AutoFormulaUno(string modelo, string marca, int cantidadRuedas, int cantPuertas, int caballosFuerza) : base(modelo, marca, cantidadRuedas, cantPuertas)
        {
            CaballosFuerza = caballosFuerza;
        }

        public int CaballosFuerza { get; set; }
    }
}
