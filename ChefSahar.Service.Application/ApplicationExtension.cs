using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using AutoMapper;
using System.Reflection;
using FluentValidation;
using ChefSahar.Service.Application.Common.Behaviors;

namespace ChefSahar.Service.Application
{
    public static class ApplicationExtension
    {
        public static void ServiceApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandleExceptionBehvior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggerRequestBehavior<,>));

        }
    }
}
