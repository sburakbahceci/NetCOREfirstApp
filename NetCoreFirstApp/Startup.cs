using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NetCoreFirstApp
{
    public class Startup
    {
        //Configure Services metodu içerisine services.AddMvc() ekleyerek mvc projesi olduğunu bildirdik.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Controller=HomePage yazan kısım default olarak projenin HomePage adlı Controller’den başlayacağı 
            //action ise o Controller’de action ismini bildiriyor. 
            //Son kısımda ise id? İle ise ek olarak id parametresi alabilir ama almasada program çalışır anlamında kullanılmaktadır.
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template:"{controller=HomePage}/{action=Index}/{id?}");
            });
            //app.UseStaticFiles() ile wwwroot klasörü altındaki css, js, resim gibi statik dosyaları kullanacağımızı bildirdik.
            app.UseStaticFiles();
            //karşılaştığımız hataların hata kodlarını dönmesi gerektiğini projeye bildirdik.
            app.UseStatusCodePages();
        }
    }
}
