using Kasznar.Application.Interfaces;
using Kasznar.Application.Services;
using Kasznar.Data.Repositories;
using Kasznar.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

// Injeção de dependência e inversão de controles
namespace Kasznar.IoC
{
    public static class NativeInjector
    {
        // Metodo responsável pela injeção de dependência
        public static void RegisterServices(IServiceCollection services)
        {
            #region  Services

            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            
            #endregion


        }
    }
}
