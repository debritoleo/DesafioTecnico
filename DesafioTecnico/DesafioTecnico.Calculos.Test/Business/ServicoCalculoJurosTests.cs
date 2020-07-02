using DesafioTecnico.Calculos.Business.Interfaces;
using DesafioTecnico.Calculos.Business.Services;
using FluentAssertions;
using Moq;
using Xunit;

namespace DesafioTecnico.Calculos.Test.Business
{
    public class ServicoCalculoJurosTests
    {
        private Mock<IServicoTaxaJuros> _servicoTaxa;
        private IServicoCalculoJuros _servicoCalculo;

        public ServicoCalculoJurosTests()
        {
            _servicoTaxa = new Mock<IServicoTaxaJuros>();
            _servicoCalculo = new ServicoCalculoJuros(_servicoTaxa.Object);
        }

        [Theory]
        [InlineData(0.01, 1000, 2, 1020.10)]
        [InlineData(1, 2000, 2, 8000)]
        [InlineData(0.01, 100, 5, 105.1010050100)]

        public void ServicoCalculoJuros_ChamarCalcularJuros_RetornarSucesso(decimal taxaJuros, decimal valorInicial, int meses, decimal valorFinal)
        {
            _servicoTaxa.Setup(x => x.ObterTaxaJuros()).Returns(taxaJuros);

            var valorCalculado = _servicoCalculo.CalcularJuros(valorInicial, meses);

            valorCalculado.Should().Be(valorFinal);
        }
    }
}
