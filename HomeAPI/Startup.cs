using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeDB;
using HomeDB.Entities;
using HomeLib;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FakeEstateAPI
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
            services.AddControllers();
            services.AddDbContext<HomeContext>(options => options.UseNpgsql(Configuration.GetConnectionString("HomeDB")));
            //repos
            services.AddScoped<IHouseRepo, HomeRepo>();
            services.AddScoped<IFeatureRepo, HomeRepo>();
            services.AddScoped<IHouseFeatureRepo, HomeRepo>();
            //services
            services.AddScoped<IHouseService, HouseService>();
            services.AddScoped<IFeatureService, FeatureService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
