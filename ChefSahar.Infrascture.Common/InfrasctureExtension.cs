using ChefSahar.Domain.Contract.Interfaces;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Infrascture.DataBase.EF;
using ChefSahar.Infrascture.DataBase.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ChefSahar.Infrascture.Common
{
    public static class InfrasctureExtension
    {
        public static void ServiceInfrascture(this IServiceCollection services)
        {
            services.AddScoped<IDbContext, AppDbContext>();
            services.AddDbContext<AppDbContext>(c => c.UseInMemoryDatabase("ChefSahar"));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
           
        }
    }
}
