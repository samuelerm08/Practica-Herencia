using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Camion
{
    public class CamionCarga : Camion
    {
        public CamionCarga(string modelo, string marca, int cantidadRuedas, double largo, double ancho, double cargaMaxima) : base(modelo, marca, cantidadRuedas, largo, ancho)
        {
            CargaMaxima = cargaMaxima;
        }

        public double CargaMaxima { get; set; }
    }
}
