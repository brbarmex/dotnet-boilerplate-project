using Boilerplate.Core.Models;
using FluentValidation;

namespace Boilerplate.Core.Validator
{
    public class CustomerModelValidation : AbstractValidator<Customer>
    {
        public CustomerModelValidation()
        {
            RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .WithMessage("Name cannot be null or empty");

            RuleFor(x => x.LastName)
            .NotNull()
            .NotEmpty()
            .WithMessage("Lastname cannot be null or empty");

            // RuleFor(x => x.Phone)
            // .NotNull()
            // .WithMessage("Phone cannot be null or empty");

            // RuleFor(x => x.Email)
            // .NotNull()
            // .WithMessage("Email cannot be null or empty")
            // .Custom((email,ctx) => {
            //     if(!email.IsValid())
            //         ctx.AddFailure("Email is not valid");
            // });
        }
    }
}