using System;
using FluentValidation.API.Models;

namespace FluentValidation.API.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.Name)
                        .NotEmpty().WithMessage("Name is required")
                        .MaximumLength(100).WithMessage("Name must have 100 chars max");

            RuleFor(u => u.Email)
                        .EmailAddress().WithMessage("Inform an valid email");

            RuleFor(u => u.Phone)
                        .NotEmpty().WithMessage("Phone is required")
                        .Phone().WithMessage("Inform an valid phone number");

            RuleFor(u => u.BirthDate)
                        .NotEmpty().WithMessage("Birth Date is required")
                        .Must(HasLegalAge).WithMessage("User must be 18 years old");
        }

        private static bool HasLegalAge(DateTime birthDate)
        {
            return birthDate <= DateTime.Now.AddYears(-18);
        }
    }
}