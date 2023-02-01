using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.Enums
{
    public enum LetterTypeEnum
    {
        [Display(Name = "کد ملی")]
        NationalCode = 1,

        [Display(Name = "شماره حساب")]
        AccountNumber = 2,

        [Display(Name = "شماره کارت")]
        CardNumber = 3,
    }
}
