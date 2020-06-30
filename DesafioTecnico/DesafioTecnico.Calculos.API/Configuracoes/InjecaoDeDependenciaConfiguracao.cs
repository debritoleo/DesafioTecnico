using DesafioTecnico.Calculos.Business.Interfaces;
using DesafioTecnico.Calculos.Business.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesafioTecnico.Calculos.API.Configuracoes
{
    public static class InjecaoDeDependenciaConfiguracao
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IServicoCalculoJuros, ServicoCalculoJuros>();
            services.AddHttpClient<IServicoTaxaJuros, ServicoAPITaxaJuros>(client =>
            {
                client.BaseAddress = new Uri(
                  configuration.GetSection("API_Taxa_Juros:UrlBase").Value);
            });

            return services;
        }
    }
}
