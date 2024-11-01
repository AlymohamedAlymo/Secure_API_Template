﻿using Microsoft.EntityFrameworkCore;
using Secure_API_Template.Data.Context;
using Secure_API_Template.Interfaces;
using Secure_API_Template.Services;

namespace Secure_API_Template.Extensions
{
    public static class AppServiceExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddCors();

            services.AddScoped<ITokenService, TokenService>();

            return services;
        }

    }
}
