using System;
using Boilerplate.Core.Bases.Entities;
using Boilerplate.Core.Bases.Interfaces;
using Boilerplate.Core.Validator;
using Boilerplate.Core.ValueObjects;

namespace Boilerplate.Core.Models
{
    public class Customer : Entity, IEntity
    {
        protected Customer() {}

        public Customer(string name, string lastName, DateTime birthDate, string email)//, string email, string phone)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            // Phone = phone;

            ValidateDomain(this, new CustomerModelValidation());
        }

        public string Name { get; }
        public string LastName {get; }
        public DateTime BirthDate {get; }
        // public Phone Phone { get; }
        public Email Email { get; }
    }
}