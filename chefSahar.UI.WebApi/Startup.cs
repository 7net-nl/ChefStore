using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ChefSahar.Infrascture.Common;
using ChefSahar.Service.Application;
using Firewall;
using FluentValidation.AspNetCore;
using Karambolo.Extensions.Logging.File;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace chefSahar.UI.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation();
            services.ServiceApplication();
            services.ServiceInfrascture();
            services.AddLogging(c =>
            {
                c.AddConsole();
                c.AddDebug();
                c.AddFile(c => c.RootPath = AppContext.BaseDirectory);
                c.AddFile(c => c.Files = new LogFileOptions[] { new LogFileOptions { Path = DateTime.Today.Date.ToShortDateString() + ".log" } });

            });

            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.ReportApiVersions = true;
            });

          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();

            }

            app.UseFirewall(FirewallRulesEngine.DenyAllAccess().ExceptFromIPAddresses(new List<IPAddress> { IPAddress.Parse("88.99.137.107") }).ExceptFromLocalhost());

            app.UseStatusCodePages();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
