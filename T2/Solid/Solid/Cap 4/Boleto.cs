namespace Solid
{
    public class Boleto
    {
        private double v;

        public Boleto(double valor)
        {
            this.Valor = valor;
        }

        public double Valor { get; internal set; }
    }
}