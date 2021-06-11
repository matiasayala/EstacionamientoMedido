
using Microsoft.Extensions.DependencyInjection;

namespace EstacionamientoMedido.Components.DigipModalFiles
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDigipModal(this IServiceCollection services)
        {
            return services.AddScoped<IDigipModalService, DigipModalService>();
        }
    }
}
