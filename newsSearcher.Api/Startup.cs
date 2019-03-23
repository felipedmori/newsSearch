using newsSearcher.Domain.Entities;
using newsSearcher.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using newsSearcher.Infra.Data;
using newsSearcher.Domain.Queries;

namespace newsSearcher.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<Config, Config>();
            services.AddTransient<QueryNews, QueryNews>();
            services.AddTransient<IGoogleNewsRepository, GoogleNewsRepository>();
            services.AddTransient<IOpenCanadaRepository, OpenCanadaRepository>();
            


            // Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "API News Searcher",
                        Version = "v1",
                        Description = "API News Searcher",
                        Contact = new Contact
                        {
                            Name = "newsSearcher",
                            Url = "https://newsSearcherURL/"
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
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "API news Searcher");
            });
        }
    }
}
