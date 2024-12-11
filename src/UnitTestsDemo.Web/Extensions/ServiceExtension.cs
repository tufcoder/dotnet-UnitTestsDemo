using UnitTestsDemo.Infrastructure.Data;
using UnitTestsDemo.Infrastructure.Extensions;

namespace UnitTestsDemo.Web.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddServiceConfigurations(
        this IServiceCollection services,
        WebApplicationBuilder builder
    )
    {
        // Add services to the container.
        builder.Services.AddRazorPages();

        services.AddInfrastructureServices(builder.Configuration);

        return services;
    }
}