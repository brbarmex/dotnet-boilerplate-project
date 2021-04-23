using System;

namespace Boilerplate.Application.DTO.Entities
{
    public class CustomerDTO
    {
        public Guid Hash {get;set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public string FullName {get; set;}
        public DateTime BirthDate {get; set;}
        public int Age {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}
        public int PhoneType {get; set;}
    }
}