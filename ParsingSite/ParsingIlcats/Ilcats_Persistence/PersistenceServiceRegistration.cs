using IlCats_Application.Contracts;
using Ilcats_Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ilcats_Persistence
{
    public static class PersistenceServiceRegistration
    {
        private const string ConnectionString = "Ilcats_DbConnectionString";

        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                connectionString = ConnectionString;

            services.AddDbContext<IlcatsDbContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString(connectionString)));
            
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IModelCarRepository, ModelCarRepository>();

            return services;
        }
    }
}
