using LibreriaHerencia.Base;

namespace LibreriaHerencia.Terrestre.Moto
{
    public abstract class Moto : TerrestreBase
    {
        public Moto(string modelo, string marca, int cantidadRuedas, int cilindrada, int rodado) : base(modelo, marca, cantidadRuedas)
        {
            Cilindrada = cilindrada;
            Rodado = rodado;
        }

        public int Cilindrada { get; set; }
        public int Rodado { get; set; }
    }
}
