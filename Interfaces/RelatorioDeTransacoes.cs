namespace Interfaces
{
    public class RelatorioDeTransacoes
    {
        public double ValorTotal { get; set; }

        public void CalcularTransacoes(ITransacao transacao)
        {
            ValorTotal += transacao.CalcularValorTotalTransacao();
        }
    }
}
