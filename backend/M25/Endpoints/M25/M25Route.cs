using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using M25.Services;

namespace M25.Endpoints.M25;

public static class M25Route
{
    public static RouteHandlerBuilder AddM25Route(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IM25Service m25Service) => new GetM25Response($"Hello, {m25Service.GetObfuscatedName(name)}!"));
    }
}