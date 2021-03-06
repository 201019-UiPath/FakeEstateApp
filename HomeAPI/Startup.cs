using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeDB;
using HomeDB.Entities;
using HomeDB.Mappers;
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
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    builder => {
                        builder.WithOrigins("*")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
            services.AddControllers();
            services.AddDbContext<HomeContext>(options => options.UseNpgsql(Configuration.GetConnectionString("HomeDB")));
            //repos
            services.AddScoped<IMapper, DBMapper>();
            services.AddScoped<IHouseMapper, DBMapper>();
            services.AddScoped<IFeature, DBMapper>();
            services.AddScoped<IHouseFeature, DBMapper>();
            services.AddScoped<IRepo, HomeRepo>();
            services.AddScoped<IHouseRepo, HomeRepo>();
            services.AddScoped<IFeatureRepo, HomeRepo>();
            services.AddScoped<IHouseFeatureRepo, HomeRepo>();
            //services
            services.AddScoped<IHouseService, HouseService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IHouseFeatureService, HouseFeatureService>();
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

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
