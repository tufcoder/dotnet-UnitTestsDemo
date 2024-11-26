using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UnitTestsDemo.Infrastructure.Data;

namespace UnitTestsDemo.Infrastructure;

public static class InfrastructureServiceExtension
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        ConfigurationManager configurationManager
    )
    {
        var connectionString = configurationManager.GetConnectionString("SQLite");

        services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));

        return services;
    }
}
