using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components
{
    public static class RazorViewLocationExtension
    {
        public static void AddComponentLocation(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(c =>
            {
                c.ViewLocationFormats.Add("/Views/Shared/Partials/{0}.cshtml");
                c.ViewLocationFormats.Add("/Components/Recipes/{0}.cshtml");
                c.ViewLocationFormats.Add("/Components/Categories/{0}.cshtml");
                c.ViewLocationFormats.Add("/Components/Tags/{0}.cshtml");
                c.ViewLocationFormats.Add("/Components/Others/{0}.cshtml");
                c.ViewLocationFormats.Add("/Components/Instructions/{0}.cshtml");
                c.ViewLocationFormats.Add("/Components/Ingridents/{0}.cshtml");

            });
        }
    }
}
