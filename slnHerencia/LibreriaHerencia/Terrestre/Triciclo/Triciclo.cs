using LibreriaHerencia.Base;

namespace LibreriaHerencia.Terrestre
{
    public class Triciclo : TerrestreBase
    {
        public Triciclo(string modelo, string marca, int cantidadRuedas, bool tieneCanasto) : base(modelo, marca, cantidadRuedas)
        {
            TieneCanasto = tieneCanasto;
        }
        public bool TieneCanasto { get; set; }
    }
}
