using System.Collections.Generic;
using AutoMapper;
using Boilerplate.Application.DTO.Entities;
using Boilerplate.Application.Interface.ICustomer;
using Boilerplate.Core.Bases.Interfaces;
using Boilerplate.Core.Interface;
using Boilerplate.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Boilerplate.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController: ControllerBase
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;
        private readonly INotification _notification;

        public CustomerController(IRepository<Customer>  customerRepository,
                                 IMapper mapper,
                                 INotification notification)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _notification = notification;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDTO>> Get()
        {
            var model = _customerRepository.Filter();
            var dto = _mapper.Map<IEnumerable<CustomerDTO>>(model);
            return Ok(dto);
        }

        [HttpPost]
        public ActionResult<CustomerDTO> Post([FromServices]ICreateCustomer useCase, [FromBody]CustomerDTO request)
        {
            var result = useCase.Execute(request);

            return Ok(result);
        }
    }
}