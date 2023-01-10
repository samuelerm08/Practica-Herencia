using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Camion
{
    public class CamionFlete : Camion
    {
        public CamionFlete(string modelo, string marca, int cantidadRuedas, double largo, double ancho, double capacidadMaxima, double altura) : base(modelo, marca, cantidadRuedas, largo, ancho)
        {
            CapacidadMaxima = capacidadMaxima;
            Altura = altura;
        }

        public double CapacidadMaxima { get; set; }
        public double Altura { get; set; }
    }
}
