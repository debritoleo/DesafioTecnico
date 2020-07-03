using DesafioTecnico.Taxas.API.Controllers;
using DesafioTecnico.Taxas.Business.Interfaces;
using DesafioTecnico.Taxas.Test.API.Factories;
using FluentAssertions;
using Moq;
using Xunit;

namespace DesafioTecnico.Taxas.Test.Controller
{
    public class TaxaJurosTests
    {
        private Mock<IServicoTaxa> _servicoTaxa;
        private TaxaController _taxaController;

        [Fact]
        public void TaxaJuros_ChamarTaxa_RetornarSucesso()
        {
            _servicoTaxa = new Mock<IServicoTaxa>();
            _taxaController = new TaxaController(_servicoTaxa.Object);

            var taxa = TaxaJurosFactory.TaxaEntidade_ObterTaxa();

            _servicoTaxa.Setup(x => x.ObterTaxa()).Returns(taxa);


            var taxaJuros = _taxaController.ObterTaxaJuros();

            taxaJuros.Should().Be("0,01");
        }
    }
}
