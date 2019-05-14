using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RRF.HttpClientFactoryWrapper.Abstract;
using RRF.JsonSerializeWrapper;
using RRF.JsonWrapper.Abstract;
using RRF.WebService.AccountControllerService;
using RRF.WebService.AccountControllerService.Abstract;
using RRF.WebService.ClientService;
using RRF.WebService.ClientService.Abstract;
using RRF.WebService.HttpClientService;
using RRF.WebService.HttpClientService.Abstract;
using RRF.WebService.JsonDTO.JsonRegisterDTO;

namespace RRF.Web
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
            services.AddHttpClient();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddScoped<IHttpClientFactoryWrapper, HttpClientFactoryWrapper.HttpClientFactoryWrapper>();
            services.AddScoped<IJsonWrapper<JsonRegisterDTO>, JsonSerializeWrapper<JsonRegisterDTO>>();

            services.AddScoped<IAccountControllerService, AccountControllerService>();
            services.AddScoped<IHttpClientService, HttpClientService>();
            services.AddScoped<IClientService, ClientService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}