using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using GB.Aurora.Domain.Arguments;
using GB.Aurora.Domain.Interfaces;
using GB.Aurora.Domain.Validators;
using GB.Aurora.Service.Aurora;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace GB.Aurora.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddFluentValidation();

            services.AddTransient<IValidator<CalcularPontosRequest>, CalcularPontosRequestValidator>();

            services.AddSingleton<IAuroraService, AuroraService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Projeto Aurora - O Jogo",
                        Version = "v1",
                        Description = "Exemplo de um jogo de dados chamado Aurora",
                        Contact = new Contact
                        {
                            Name = "Gabriel Brandão",
                            Email = "gabrielbrandaodev@gmail.com"
                        }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Projeto Aurora - O Jogo");
            });
        }
    }
}
