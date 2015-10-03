using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces
{
    [TestClass]
    public class InterfacesTests
    {
        [TestMethod]
        public void DeveCalcularTotalTransacaoCredito()
        {
            ITransacao transacaoCred = new Credito(150.0);

            var expectedTotalCredito = transacaoCred.CalcularValorTotalTransacao();

            const double actual = 157.5;

            Assert.AreEqual(expectedTotalCredito, actual);
        }

        [TestMethod]
        public void DeveCalcularTotalTransacaoDebito()
        {
            ITransacao transacaoDeb = new Debito(100.0);

            var expectedTotalDebito = transacaoDeb.CalcularValorTotalTransacao();

            Assert.AreEqual(expectedTotalDebito, 102);
        }

        [TestMethod]
        public void DeveCalcularValorTotalEmTransacoes()
        {
            ITransacao transacaoCred = new Credito(125.0);
            ITransacao transacaoDeb = new Debito(227.0);

            var relatorio = new RelatorioDeTransacoes();
            relatorio.CalcularTransacoes(transacaoCred);
            relatorio.CalcularTransacoes(transacaoDeb);

            var expected = relatorio.ValorTotal;
            const double actual = 362.79;

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
