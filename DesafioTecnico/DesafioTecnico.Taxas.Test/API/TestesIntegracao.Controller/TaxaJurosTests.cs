using DesafioTecnico.Taxas.API.Controllers;
using DesafioTecnico.Taxas.Business.Interfaces;
using DesafioTecnico.Taxas.Test.API.Factories;
using FluentAssertions;
using Moq;
using Xunit;

namespace DesafioTecnico.Taxas.Test.TestesIntegracao.Controller
{
    public class TaxaJurosTests
    {
        private Mock<IServicoTaxa> _servicoTaxa;
        private TaxaController _taxaController;

        [Fact]
        public void TaxaJuros_ChamarTaxa_RetornarSucesso()
        {
            const string TAXA_JUROS_DEFAULT = "0,01";

            _servicoTaxa = new Mock<IServicoTaxa>();
            _taxaController = new TaxaController(_servicoTaxa.Object);

            var taxa = TaxaJurosFactory.TaxaEntidade_ObterTaxa();

            _servicoTaxa.Setup(x => x.ObterTaxa()).Returns(taxa);


            var resposta = _taxaController.ObterTaxaJuros();

            resposta.Should().Be(TAXA_JUROS_DEFAULT);
        }
    }
}
