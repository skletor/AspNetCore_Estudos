using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.Diagnostics;

namespace MinimalMvcAspNetCore{
    public class Startup{
        
        public void Configure(IApplicationBuilder app){
            
            app.UseDeveloperExceptionPage();
            
            app.UseMvc(
                routes => {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller}/{action}/{id?}",
                        defaults: new {controller = "Home", action = "Index"} 
                    ); 
            });            
            
        }
        
        public void ConfigureServices(IServiceCollection services){
            services.AddMvc();
        }
        
        
    }
}