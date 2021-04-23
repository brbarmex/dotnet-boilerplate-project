using AutoMapper;
using Boilerplate.Application.DTO.Entities;
using Boilerplate.Core.Models;

namespace Boilerplate.Boilerplate.Application.DTO
{
    public class DtoToDomain : Profile
    {
        public DtoToDomain()
        {
            CreateMap<Customer, CustomerDTO>()
                .ForMember(c => c.Hash, m => m.MapFrom(x => x.Id))
                .ForMember(c => c.Name, m => m.MapFrom(x => x.Name))
                .ForMember(c => c.LastName, m => m.MapFrom(x => x.LastName))
                .ForMember(c => c.Email, m => m.MapFrom(x => x.Email))
                .ForMember(c => c.BirthDate, m => m.MapFrom(x => x.BirthDate))
                //.ForMember(c => c.Phone, m => m.MapFrom(x => x.Phone))
                .ReverseMap();
        }
    }
}