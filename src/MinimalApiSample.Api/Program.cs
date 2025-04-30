using MinimalApiSample.Api.Extensions;

WebApplication BuildApplication(string[] args) {
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddOpenApi();

    return builder.Build();
}

void RunApp(WebApplication app)
{
    app.UseEndpoint();
    app.Run();
}

RunApp(BuildApplication(args));
