using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web.UI;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;
using SouDizimista.Repository.Repository;
using SouDizimista.Services.Interfaces;
using SouDizimista.Services.Services;
using System;

namespace SouDizimista.WebApp
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
            services.AddControllersWithViews();

            services.AddControllersWithViews();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<Context>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("BASE"))); 

            services.AddRazorPages().AddMicrosoftIdentityUI();
            services.AddScoped(typeof(IDizimistaRepository), typeof(DizimistaRepository));
            services.AddScoped(typeof(IParoquiaRepository), typeof(ParoquiaRepository));
            services.AddScoped(typeof(IEnderecoRepository), typeof(EnderecoRepository));

            services.AddScoped(typeof(IDizimistaServices), typeof(DizimistaServices));
            services.AddScoped(typeof(IParoquiaRepository), typeof(ParoquiaRepository));
            services.AddScoped(typeof(IEnderecoServices), typeof(EnderecoServices));
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
