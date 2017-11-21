using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCItemGen.Model;

namespace MVCItemGen
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                                        .SetBasePath(hostingEnvironment.ContentRootPath)
                                        .AddJsonFile("appsettings.json")
                                        .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //var connection = @"Server=(localsqlserver);Database=MVCItemGen;";
            //var connection = @"Server=WEB-SERVER\SQLEXPRESS;User Id=bakerc;Password=Sprint00;Initial Catalog=MVCItemGen;Integrated Security=False;Connect Timeout=30;";

            services.AddDbContext<ItemDbContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<ItemDbContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("TestConnection")));
            services.AddTransient<IBaseItemRepository, ItemRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
