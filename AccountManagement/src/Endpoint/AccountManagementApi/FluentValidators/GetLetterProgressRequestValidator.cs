using AccountManagement.Contract.Dto;
using FluentValidation;

namespace AccountManagementApi.FluentValidators
{
    public class GetLetterProgressRequestValidator : AbstractValidator<GetLetterProgressRequest>
    {
        public GetLetterProgressRequestValidator()
        {
            //RuleFor(p => p.TrackingCode)
            //    .NotEmpty().WithMessage("")
            //    .Length(16, 62).WithMessage("")
            //    .NotNull().WithMessage("کد را وارد کنید");
                
        }
    }
}
