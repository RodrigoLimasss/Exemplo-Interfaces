namespace Interfaces
{
    public class Credito : Operacao, ITransacao
    {
        public Credito(double valor)
            : base(valor)
        {
        }

        public double CalcularValorTotalTransacao()
        {
            return Valor += Valor * 0.05;
        }
    }
}
