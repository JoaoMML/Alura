namespace Solid
{
    public class Pagamento
    {
        private object bOLETO;

        public Pagamento(double valor, object bOLETO)
        {
            Valor = valor;
            this.bOLETO = bOLETO;
        }

        public double Valor { get; internal set; }
    }
}