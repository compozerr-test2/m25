using Carter;
using Microsoft.AspNetCore.Routing;

namespace M25.Endpoints.M25;

public class M25Group : CarterModule
{
    public M25Group() : base("/m25")
    {
        WithTags(nameof(M25));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddM25Route();
    }
}