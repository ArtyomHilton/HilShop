using HilShop.Application.Abstractions;
using HilShop.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HilShop.Infrastructure;

public static class DependencyInjections
{
    extension(IServiceCollection serviceCollection)
    {
        public IServiceCollection AddInfrastructureDependencyInjections()
        {
            serviceCollection.AddServices();

            return serviceCollection;
        }

        private IServiceCollection AddServices()
        {
            serviceCollection.AddSingleton<IHashingService, HashingService>();

            return serviceCollection;
        }
    }
}
