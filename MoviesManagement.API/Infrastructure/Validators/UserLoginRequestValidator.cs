using FluentValidation;
using MoviesManagement.API.Models.Request;

namespace MoviesManagement.API.Infrastructure.Validators
{
    public class UserLoginRequestValidator : AbstractValidator<AccountLoginDTO>
    {
        public UserLoginRequestValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty();


            RuleFor(x => x.Password)
                .NotEmpty();
        }
    }
}
