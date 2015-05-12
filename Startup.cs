using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace aspnetcast
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "api",
                        template: "api/{controller}/{id?}");
                });
        }
    }
}