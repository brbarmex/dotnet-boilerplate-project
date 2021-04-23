using Boilerplate.Application.DTO.Entities;

namespace Boilerplate.Application.Interface.ICustomer
{
    public interface ICreateCustomer
    {
        CustomerDTO Execute(CustomerDTO customer);
    }
}