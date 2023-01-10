using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Bicicleta
{
    public class BiciCarrera : Bicicleta
    {
        public BiciCarrera(string modelo, string marca, int cantidadRuedas, int rodado, int cantCambios) : base(modelo, marca, cantidadRuedas, rodado)
        {
            CantCambios = cantCambios;
        }

        public int CantCambios { get; set; }
    }
}
