using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NormativeCalculator.Database.EF;
using NormativeCalculator.Service.Interface;
using NormativeCalculator.Service.Service;
using NormativeCalculator.Service.IngredientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NormativeCalculator.Database.Authentication;

namespace NormativeCalculator
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NormativeCalculator", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IRecipeCategoryService, RecipeCategoryService>();
            services.AddDbContext<NormativeCalculatorDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IAuthRepository, AuthRepository>(); ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NormativeCalculator v1"));
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
