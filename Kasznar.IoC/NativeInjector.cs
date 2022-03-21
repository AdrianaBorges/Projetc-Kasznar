using Kasznar.Application.Interfaces;
using Kasznar.Application.Services;
using Microsoft.Extensions.DependencyInjection;

// Injeção de dependência e inversão de controles
namespace Kasznar.IoC
{
    public class NativeInjector
    {
        // Metodo responsável pela injeção de dependência
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

        }
    }
}
