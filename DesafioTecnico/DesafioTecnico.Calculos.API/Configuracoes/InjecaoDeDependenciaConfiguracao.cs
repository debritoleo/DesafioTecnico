using DesafioTecnico.Calculos.Business.Interfaces;
using DesafioTecnico.Calculos.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioTecnico.Calculos.API.Configuracoes
{
    public static class InjecaoDeDependenciaConfiguracao
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IServicoCalculoJuros, ServicoCalculoJuros>();
            services.AddScoped<IServicoTaxaJuros, ServicoAPITaxaJuros>();

            return services;
        }
    }
}
