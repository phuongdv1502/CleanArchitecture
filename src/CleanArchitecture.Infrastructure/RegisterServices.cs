using CleanArchitecture.Application.DatabaseServices;
using CleanArchitecture.Infrastructure.DatabaseServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class RegisterServices
    {
        
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDapper, Dapperr>();
            services.AddTransient<IDatabaseConnectionFactory>(e =>
            {
                return new SqlConnectionFactory(configuration["ConnectionStrings:CleanArchitectureDB"]);
            });
            return services;
        }
    }
}
