using UnitTestsDemo.Infrastructure;

namespace UnitTestsDemo.Web.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServiceConfigurations
    (
        this IServiceCollection services,
        WebApplicationBuilder builder
    )
    {
        services.AddInfrastructureServices(builder.Configuration);

        return services;
    }
}
