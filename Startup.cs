using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsORM.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sports_ORM
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
 private bool IsDevelopment = true;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            using(var client = new Context(new DbContextOptions<Context>()))
            {
                client.Database.EnsureCreated();
            }

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();

            services.AddDbContext<Context>(options => options.UseSqlite("Data Source=SportsORM.db"));

            services.AddMvc(options => options.EnableEndpointRouting = false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (IsDevelopment)
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseSession();

            app.UseAuthorization();

            app.UseMvc();

        }
    }
}
