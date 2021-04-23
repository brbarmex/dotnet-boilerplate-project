using Boilerplate.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Boilerplate.Core.Interface;
using Boilerplate.Application.Interface.ICustomer;
using Boilerplate.Application.Services.CustomerUseCase;
using Boilerplate.Core.Bases;
using Boilerplate.Core.Bases.Interfaces;

namespace Boilerplate.Infraestructure.CrossCutting
{
    public static class ContainerDI
    {
        public static void RegisterRepositoryIoC(this IServiceCollection services)
        => services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        public static void RegisterUseCaseIoC(this IServiceCollection services)
        => services.AddScoped<ICreateCustomer, Create>();

        public static void RegisterNotificationIoC(this IServiceCollection services)
        => services.AddScoped<INotification, DomainNotification>();
    }
}