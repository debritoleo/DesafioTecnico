using System.Linq;
using DesafioTecnico.Calculos.API.Models;
using FluentAssertions;
using Xunit;

namespace DesafioTecnico.Calculos.Test.API
{
    public class CalculoJurosValidacaoModelTests
    {
        private readonly CalculoJurosValidacaoModel _modelValidacao;
        public CalculoJurosValidacaoModelTests()
        {
            _modelValidacao = new CalculoJurosValidacaoModel();
        }

        [Theory]
        [InlineData(null, "6", "Informe o valor inicial")]
        [InlineData("", "6", "Informe o valor inicial")]
        [InlineData("teste", "6", "Informe um número válido para valor inicial")]
        [InlineData("-10", "6", "Informe um número válido para valor inicial")]
        [InlineData("c1", "6", "Informe um número válido para valor inicial")]
        [InlineData("100", null, "Informe o número de meses")]
        [InlineData("100", "", "Informe o número de meses")]
        [InlineData("100", "22.8", "Meses deve ser um número válido")]
        [InlineData("100", "-1", "Meses deve ser um número válido")]
        public void CalculoJurosValidacaoModel_Validar_RetornarFalha(string valorInicial, string meses, string erro)
        {
            var result = _modelValidacao.Validar(valorInicial, meses);

            result.Should().BeFalse();
            _modelValidacao.Erros.FirstOrDefault().Should().Be(erro);
        }
    }
}
