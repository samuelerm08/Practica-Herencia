using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencia.Terrestre.Moto
{
    public class Motomel : Moto
    {
        public Motomel(string modelo, string marca, int cantidadRuedas, int cilindrada, int rodado, bool cambioAutomatico) : base(modelo, marca, cantidadRuedas, cilindrada, rodado)
        {
            CambioAutomatico = cambioAutomatico;
        }
        public bool CambioAutomatico { get; set; }
    }
}
