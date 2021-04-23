using AutoMapper;
using Boilerplate.Boilerplate.Application.DTO;
using Boilerplate.Boilerplate.Application.DTO.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Boilerplate.Infraestructure.BootStraper
{
    public static class AutoMapperSetup
    {
        public static void AutoMapperEnable(this IServiceCollection services)
        => services
          .AddSingleton(
              new MapperConfiguration(config =>
              {
                  config.AddProfile(new DtoToDomain());
                  config.AddProfile(new DomainToDTO());
              })
              .CreateMapper());
    }
}