using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using MediatR;
using MicroRabbit.Infra.IoC;
using MicroRabbit.Transfer.Data.Context;
>>>>>>> 010f101495ae8764e28d06263c2d94425f9be350
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 010f101495ae8764e28d06263c2d94425f9be350
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace MicroRabbit.Transfer.Api
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
<<<<<<< HEAD
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "MicroRabbit.Transfer.Api", Version = "v1"});
            });
=======
            services.AddMediatR(typeof(Startup));

            services.AddDbContext<TransferDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("TransferDbConnection"));
            });

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Transfer API", Version = "v1" });
            });

            RegisterServices(services);
        }

        private void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
>>>>>>> 010f101495ae8764e28d06263c2d94425f9be350
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
<<<<<<< HEAD
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MicroRabbit.Transfer.Api v1"));
=======
>>>>>>> 010f101495ae8764e28d06263c2d94425f9be350
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

<<<<<<< HEAD
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
=======
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Transfer Microservice V1");
            });
>>>>>>> 010f101495ae8764e28d06263c2d94425f9be350
        }
    }
}