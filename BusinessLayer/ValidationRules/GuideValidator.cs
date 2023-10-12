using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter Guide Name!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter Guide Description!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please enter Guide Image!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please enter the max. 30 character!");
            RuleFor(x => x.Name).MinimumLength(6).WithMessage("Please enter the min. 6 character!");
        }
    }
}
