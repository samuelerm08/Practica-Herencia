using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Base
{
    public abstract class AereoBase
    {
        public AereoBase(string modelo, string marca, int cantPasajeros)
        {
            Modelo = modelo;
            Marca = marca;            
            CantPasajeros = cantPasajeros;
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }        
        public int CantPasajeros { get; set; }
    }
}
