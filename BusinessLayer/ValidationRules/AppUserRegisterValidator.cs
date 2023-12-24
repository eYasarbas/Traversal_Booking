using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules;

public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
{
    public AppUserRegisterValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name area doesn't exist");
        RuleFor(x => x.SurName).NotEmpty().WithMessage("Surname area doesn't exist");
        RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail area doesn't exist");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password area doesn't exist");
        RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm Password area doesn't exist");
        RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Username area doesn't less than 5 character");
        RuleFor(x => x.UserName).MaximumLength(11).WithMessage("Username area doesn't more thane 11 character");
        RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("password aren't equals each other");
    }
}