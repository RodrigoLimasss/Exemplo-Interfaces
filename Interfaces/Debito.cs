namespace Interfaces
{
    public class Debito : Operacao, ITransacao
    {
        public Debito(double valor)
            : base(valor)
        {
        }

        public double CalcularValorTotalTransacao()
        {
            return Valor += Valor * 0.02;
        }
    }
}
