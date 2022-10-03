using System.Reflection;
using IlCats_API.Filters;
using IlCats_Application;
using Ilcats_Persistence;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IlCats_API
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddPersistenceServices(Configuration,
                "IlCatsDbConnectionString"); //TODO: move to settings

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services
                .AddControllers(/*config => config.Filters.Add (new CustomExceptionFilterAttribute(_env))*/)
                .AddNewtonsoftJson();
            services.AddAutoMapper(typeof(Startup));

            services.AddCors(opts =>
            {
                opts.AddPolicy("Open",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            AddSwagger(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseOpenApi();

            app.UseSwaggerUi3(opts =>
            {
                opts.DocumentTitle = "MirrorLink.Api";
            });

            app.UseCors("Open");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerDocument(settings =>
            {
                settings.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "MirrorLink.Api";
                };
            });
        }
    }
}
