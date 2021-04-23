using AutoMapper;
using Boilerplate.Application.DTO.Entities;
using Boilerplate.Core.Models;

namespace Boilerplate.Boilerplate.Application.DTO.Mapper
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            CreateMap<CustomerDTO, Customer>()
            .ConstructUsing(c => new Customer(c.Name, c.LastName, c.BirthDate, c.Email));//, c.Email, c.Phone));
        }
    }
}