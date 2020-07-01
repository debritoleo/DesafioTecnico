using DesafioTecnico.Calculos.Business.Interfaces;
using System;

namespace DesafioTecnico.Calculos.Business.Services
{
    public class ServicoCalculoJuros : IServicoCalculoJuros
    {
        private readonly IServicoTaxaJuros _service;
        public ServicoCalculoJuros(IServicoTaxaJuros service)
        {
            _service = service;
        }
        public decimal CalcularJuros(decimal valorInicial, int meses)
        {
            var taxa = _service.ObterTaxaJuros();
            var valorCalculado = valorInicial * (decimal)Math.Pow(1 + (double)taxa, meses);

            return valorCalculado;
        }
    }
}
