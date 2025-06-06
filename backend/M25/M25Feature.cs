using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using M25.Services;

namespace M25;

public class M25Feature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IM25Service, M25Service>();
    }
}