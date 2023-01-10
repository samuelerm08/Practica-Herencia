using LibreriaHerencia.Base;

namespace LibreriaHerencia.Terrestre.Bicicleta
{
    public abstract class Bicicleta : TerrestreBase
    {
        public Bicicleta(string modelo, string marca, int cantidadRuedas, int rodado) : base(modelo, marca, cantidadRuedas)
        {
            Rodado = rodado;
        }

        public int Rodado { get; set; }
    }
}

