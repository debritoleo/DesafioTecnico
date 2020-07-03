using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace DesafioTecnico.Calculos.API.Configuracoes
{
    public static class SwaggerConfiguracao
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Desafio Técnico - Cálculo Juros API",
                Description = "Esta API faz parte do desafio técnico - ASP.NET Core WebAPI.",
                Contact = new OpenApiContact()
                {
                    Name = "Leonardo de Brito",
                    Email = "leobritop7@gmail.com"
                },
                License = new OpenApiLicense()
                {
                    Name = "MIT",
                    Url = new Uri("https://opensource.org/licenses/MIT")
                }
            }));

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio Técnico - Cálculo API");
            });
            return app;
        }
    }
}
