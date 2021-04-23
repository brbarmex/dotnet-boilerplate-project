using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Boilerplate.Core.Bases.Entities;
using FluentValidation;
using FluentValidation.Results;

namespace Boilerplate.Core.Bases
{
    [NotMapped]
    public abstract class Validator
    {
        protected Validator()
        => Notifications = new List<Notification>(0);

        protected bool ValidateDomain<TModel>(TModel model, AbstractValidator<TModel> validator, bool throwWhenFailure =false)
        {
            if(throwWhenFailure)
                validator.ValidateAndThrow(model);

            ErrorMessages = validator.Validate(model);

            foreach (var err in ErrorMessages.Errors)
                Notifications.Add(new Notification(err.ErrorCode, err.ErrorMessage));

            return IsValid = ErrorMessages.IsValid;
        }

        [NotMapped]
        public bool IsValid { get; private set; }

        [NotMapped]
        public ValidationResult ErrorMessages { get; internal set; }

        [NotMapped]
        public List<Notification> Notifications { get; }
    }
}