using System;
using Assignment.Contracts.DTO;
using FluentValidation;

namespace Assignment.Core.Validators;

public class CreateUsersDTOValidator : AbstractValidator<CreateUsersDTO>
    {
        public CreateUsersDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Provide passsword");
        }
    }