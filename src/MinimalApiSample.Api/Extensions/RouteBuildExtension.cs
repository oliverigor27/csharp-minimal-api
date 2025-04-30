using MinimalApiSample.Api.Endpoint;

namespace MinimalApiSample.Api.Extensions;

public static class RouteBuildExtension
{
    public static WebApplication UseEndpoint(this WebApplication app)
    {
        var builder = app.MapGroup("");

        return app;
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder builder) 
        where TEndpoint : IEndpoint
    {
        TEndpoint.MapEndpoint(builder);
        return builder;
    }

    private static IEndpointRouteBuilder MapFirstRoute(this IEndpointRouteBuilder builder)
    {
        builder.MapGroup("/first")
            .WithTags("First minimal API Route");

        return builder;
    }

}
