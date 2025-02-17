using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace asp_service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration? Configuration { set; get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<KestrelServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.Configure<IISServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.AddControllers();
            services.AddCors(o => o.AddDefaultPolicy(
                b => b.AllowAnyOrigin()));
        }

        public void Configure(IApplicationBuilder app,
            Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseExceptionHandler("/Error");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
