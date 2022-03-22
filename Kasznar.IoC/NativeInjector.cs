using Microsoft.Extensions.DependencyInjection;
using System;
using Kasznar.Application.Interfaces;
using Kasznar.Application.Services;
using Kasznar.Data.Repositories;
using Kasznar.Domain.Interfaces;

namespace Kasznar.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion
        }
    }
}