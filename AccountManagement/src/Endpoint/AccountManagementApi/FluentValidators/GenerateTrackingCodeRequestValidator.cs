using AccountManagement.Contract.Dto;
using AccountManagement.Domain.Entities;
using FluentValidation;

namespace AccountManagementApi.FluentValidators
{
    public class GenerateTrackingCodeRequestValidator : AbstractValidator<GenerateTrackingCodeRequest>
    {
        public GenerateTrackingCodeRequestValidator()
        {
            //RuleFor(x => x.ReceiptDate).NotNull().WithErrorCode("ShouldNotBeEmpty");
            //RuleFor(x => x.ReceiptDate !=null);


            RuleFor(x => x.ReceiptDate)
                .NotNull().WithMessage("تاریخ دریافت نامه را وارد کنید ")
                .MinimumLength(10).WithMessage("فرمت تاریخ دریافت نامه نامعتبر می باشد")
                .NotEmpty().WithMessage("تاریخ دریافت نامه را وارد کنید")
                .GreaterThanOrEqualTo(x => x.LetterDate).WithMessage("تاریخ رسید باید بیشتر یا مساوی تاریخ نامه باشد")
                .Matches(@"14\d{2}\/((0[1-9])|(1[0-2]))\/((0[1-9])|(1[0-9])|(2[0-9])|(3[0-1]))$");

            RuleFor(x => x.LetterDate)
                .NotNull().WithMessage("تاریخ نامه را وارد کنید ")
                .NotEmpty().WithMessage("تاریخ نامه را وارد کنید")
                .Matches(@"14\d{2}\/((0[1-9])|(1[0-2]))\/((0[1-9])|(1[0-9])|(2[0-9])|(3[0-1]))$"); 



            RuleFor(x => x.Deadline)
                .NotEmpty().WithMessage("را وارد کنید {Deadline} تاریخ")
                .MinimumLength(1).WithMessage("فرمت تاریخ رفع اثر نامه نامعتبر می باشد")
                .GreaterThan(x => x.LetterDate).WithMessage("تاریخ رفع اثر نامه باید بیشتر از تاریخ نامه باشد")
                .Matches(@"14\d{2}\/((0[1-9])|(1[0-2]))\/((0[1-9])|(1[0-9])|(2[0-9])|(3[0-1]))$");

            RuleFor(x => x.LetterTitle)
                .Length(10, 200).WithMessage("فرمت عنوان نامه صحیح نمی باشد")
                .NotEmpty().WithMessage("عنوان نامه را وارد کنید")
                .NotNull().WithMessage("عنوان نامه را وارد کنید");
                



            RuleFor(x => x.LetterNumber)
                .Length(10, 50).WithMessage("فرمت شماره نامه صحیح نمی باشد")
                .NotEmpty().WithMessage("شماره نامه را وارد کنید")
                .NotNull().WithMessage("شماره نامه را وارد کنید");
                





            
                
        }
    }
}
