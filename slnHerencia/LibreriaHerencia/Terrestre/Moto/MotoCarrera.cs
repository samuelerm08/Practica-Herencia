using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Moto
{
    public class MotoCarrera : Moto
    {
        public MotoCarrera(string modelo, string marca, int cantidadRuedas, int cilindrada, int rodado, string escuderia) : base(modelo, marca, cantidadRuedas, cilindrada, rodado)
        {
            Escuderia = escuderia;
        }

        public string Escuderia { get; set; }
    }
}
