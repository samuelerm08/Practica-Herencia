using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Base
{
    public abstract class TerrestreBase
    {
        public TerrestreBase(string modelo, string marca, int cantidadRuedas)
        {
            Modelo = modelo;
            Marca = marca;
            CantidadRuedas = cantidadRuedas;
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int CantidadRuedas { get; set; }             
    }
}
