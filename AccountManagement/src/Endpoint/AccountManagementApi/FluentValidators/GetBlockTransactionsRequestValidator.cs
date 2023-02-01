using AccountManagement.Contract.Dto;
using FluentValidation;

namespace AccountManagementApi.FluentValidators
{
    public class GetBlockTransactionsRequestValidator: AbstractValidator <GetBlockTransactionsRequest>

    {
        public GetBlockTransactionsRequestValidator()
        {
            
            //RuleFor(T => T.TrackingCode)
            //    .NotEmpty()
            //    .NotNull().WithMessage("")
            //    .MaxLength(16,64).WithMessage("");

        }
        //private Guid IsValid()
        //{

        //    var xquid = new Guid();
        //    bool isValid = Guid.TryParse(input.ToString(), out xquid);
        //    return isValid;
        //}
    }
}
