using DesafioTecnico.Calculos.Business.Interfaces;
using System.Net.Http;

namespace DesafioTecnico.Calculos.Business.Services
{
    public class ServicoAPITaxaJuros : IServicoTaxaJuros
    {
        private readonly HttpClient _client;

        public ServicoAPITaxaJuros(HttpClient client)
        {
            _client = client;
        }

        public decimal ObterTaxaJuros()
        {
            var resultado = _client.GetAsync("/taxaJuros").Result;

            string conteudo = resultado.Content.ReadAsStringAsync().Result;
            
            return decimal.Parse(conteudo);
        }
    }
}
