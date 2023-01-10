using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaHerencia.Base;

namespace LibreriaHerencia.Terrestre.Auto
{
    public abstract class Auto : TerrestreBase
    {
        public Auto(string modelo, string marca, int cantidadRuedas, int cantPuertas)
                                : base(modelo, marca, cantidadRuedas)
        {
            CantPuertas = cantPuertas;
        }
        public int CantPuertas { get; set; }     
    }
}
