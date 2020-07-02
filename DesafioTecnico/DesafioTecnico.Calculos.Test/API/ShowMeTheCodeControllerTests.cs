using DesafioTecnico.Calculos.API.Controllers;
using DesafioTecnico.Calculos.API.Utils;
using FluentAssertions;
using Xunit;

namespace DesafioTecnico.Calculos.Test.API
{
    public class ShowMeTheCodeControllerTests
    {
        [Fact]
        public void ShowMeTheCode_ChamarObter_RetornarSucesso()
        {
            var url = new ShowMeTheCodeController().Obter();

            url.Should().Be(Constantes.URL_GITHUB);
        }
    }
}
