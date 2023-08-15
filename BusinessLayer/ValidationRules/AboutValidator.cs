using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Description).NotEmpty().WithMessage("You can't skip the description!");
			RuleFor(x => x.Image1).NotEmpty().WithMessage("Please Select any Image !");
			RuleFor(x => x.Description).MinimumLength(50).WithMessage("Please enter min. 50 character !");
			RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Please enter max. 1500 character !");
		}
	}
}
