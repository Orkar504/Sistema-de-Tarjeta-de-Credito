using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Tarjeta_de_Credito
{
    public class Startup
    {
        const string galleta = "cookie"; //para crear una cookies
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(galleta).AddCookie(galleta, options =>
            {
                options.Cookie.Name = galleta;
                options.LoginPath = "Identity/Account/Login"; // especifica la página del Login
                options.AccessDeniedPath = "Identity/Account/AccessDenied"; // Especifícala ´página del acceso denegado

              
            });

            services.AddAuthorization(options =>
            {
                //Genera una política que solo permite a los usuarios del Departamento de Solicitudes accedan a X página con esta política
                options.AddPolicy("Empleado", policy => policy.RequireClaim("Puesto", "Solicitudes"));

            });
            services.AddRazorPages();
        }


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
            app.UseHttpsRedirection();  
            app.UseStaticFiles();   

            app.UseRouting();

            app.UseAuthentication();        
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
       

        
    }
}
