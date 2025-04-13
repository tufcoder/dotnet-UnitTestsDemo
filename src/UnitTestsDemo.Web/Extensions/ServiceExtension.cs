using UnitTestsDemo.Infrastructure.Data;
using UnitTestsDemo.Infrastructure.Extensions;

namespace UnitTestsDemo.Web.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddServiceConfigurations(
        this IServiceCollection services,
        WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();

        services.AddInfrastructureServices(builder.Configuration);

        return services;
    }
}