using DesafioTecnico.Taxas.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.Taxas.API.Controllers
{
    [ApiController]
    public class TaxaController : ControllerBase
    {
        private readonly IServicoTaxa _servicoTaxa;
        public TaxaController(IServicoTaxa servicoTaxa)
        {
            _servicoTaxa = servicoTaxa;
        }

        [HttpGet("taxaJuros")]
        public string ObterTaxaJuros()
        {
            var taxa = _servicoTaxa.ObterTaxa();
            return $"{taxa.Valor}";
        }
    }
}