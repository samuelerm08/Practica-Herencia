using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Moto
{
    public class MotoConSidecar : Moto
    {
        public MotoConSidecar(string modelo, string marca, int cantidadRuedas, int cilindrada, int rodado, double pesoMaximo) : base(modelo, marca, cantidadRuedas, cilindrada, rodado)
        {
            PesoMaximo = pesoMaximo;
        }

        public double PesoMaximo { get; set; }
    }
}
