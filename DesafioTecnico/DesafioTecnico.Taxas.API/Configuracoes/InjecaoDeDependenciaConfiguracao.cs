using DesafioTecnico.Taxas.Business.Interfaces;
using DesafioTecnico.Taxas.Business.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioTecnico.Taxas.API.Configuracoes
{
    public static class InjecaoDeDependenciaConfiguracao
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IServicoTaxa, ServicoTaxa>();

            return services;
        }
    }
}
