using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Kasznar.Swagger
{
    public static class SwaggerSetup
    {
        public static IServiceCollection AddSwaggerConfigurarion(this IServiceCollection service)
        {
            return service.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Kasznar .Net Core",
                    Version = "v1",
                    Description = "Exercício –Kasznar Leonardos.",
                    Contact = new OpenApiContact
                    {
                        Name = "Adriana Borges",
                        Email = "drika.fonseca.borges@gmail.com"
                    }
                });
                string xmlPath = Path.Combine("wwwroot", "api-doc.xml");

                opt.IncludeXmlComments(xmlPath);

            });
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            return app.UseSwagger().UseSwaggerUI(c =>
            {
                c.RoutePrefix = "documentation";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");

            });
        }
    }
}
