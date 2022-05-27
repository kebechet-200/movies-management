using FluentValidation;
using MoviesManagement.API.Models.Request;

namespace MoviesManagement.API.Infrastructure.Validators
{
    public class UserRegisterRequestValidator : AbstractValidator<AccountRegisterDTO>
    {
        public UserRegisterRequestValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .MaximumLength(15);


            RuleFor(x => x.Password)
                .NotEmpty()
                .MaximumLength(30)
                .MinimumLength(5);

            RuleFor(x => x.Email)
                .EmailAddress();
        }
    }
}
