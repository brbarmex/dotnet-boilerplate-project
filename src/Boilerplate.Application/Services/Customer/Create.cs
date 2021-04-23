using AutoMapper;
using Boilerplate.Application.DTO.Entities;
using Boilerplate.Application.Interface.ICustomer;
using Boilerplate.Core.Bases.Interfaces;
using Boilerplate.Core.Interface;
using Boilerplate.Core.Models;

namespace Boilerplate.Application.Services.CustomerUseCase
{
    /// <summary>
    /// For more detail see the documentation in customer.create.md
    /// </summary>
    public sealed class Create : IUseCase, ICreateCustomer
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly INotification _notification;
        private readonly IMapper _mapper;

        public Create(IRepository<Customer> customerRepository,
                      INotification notification,
                      IMapper mapper)
        {
            _customerRepository = customerRepository;
            _notification = notification;
            _mapper = mapper;
        }

        public CustomerDTO Execute(CustomerDTO customer)
        {
            var _customer = _mapper.Map<Customer>(customer);

            if(!_customer.IsValid)
            {
                _notification.AddNotification(_customer.Notifications);
                return customer;
            }

            // var checkIfAlreadyExists = _customerRepository.GetById(customer.Hash);

            // if(checkIfAlreadyExists != null)
            // {
            //     _notification.AddNotification("customer","already exist");
            //     return customer;
            // }

            _customerRepository.Create(_customer);

            return _mapper.Map<CustomerDTO>(_customer);
        }
    }
}