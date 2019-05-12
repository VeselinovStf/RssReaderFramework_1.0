using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RRF.API.ViewModels.Identity;
using RRF.ClientControllerValidation;
using RRF.Core.Container;
using RRF.EFModels;
using RRF.IdentityControllerValidator.Abstract;
using RRF.InvokeMiddleware;
using Swashbuckle.AspNetCore.Swagger;

namespace RRF.API
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
            RssReaderFrameworkConfigure
                .GoRssReaderFrameworkToWork(
                services,
                Configuration.GetConnectionString("DevelopmentConnectionString")
                );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "RRF API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Veselinov Stefan",
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }
                });
            });

            ConfigureAPIServices(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        private void ConfigureAPIServices(IServiceCollection services)
        {
            services.AddScoped<IIdentityControllerValidator, ClientControllerValidation.ClientControllerValidation>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            //app.UseRssReaderFramework();
            app.UseAuthentication();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvc(routes =>
           {
               routes.MapRoute(
                   name: "RssControl",
                   template: "api/Rss/{apiKey}",
                   defaults: new { controller = "Rss" }
                   );

               routes.MapRoute(
                   name: "Register",
                   template: "api/Client/",
                   defaults: new { controller = "Client" }
                   );
           });
        }
    }
}