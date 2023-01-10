using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Aereo.Avion
{
    public class Hidroavion : Avion
    {
        public Hidroavion(string modelo, string marca, int cantPasajeros, int cantidadMotores, string categoria) : base(modelo, marca, cantPasajeros, cantidadMotores)
        {
            Categoria = categoria;
        }
        
        //Flotadores e Hidrocanoas
        public string Categoria { get; set; }
    }
}
