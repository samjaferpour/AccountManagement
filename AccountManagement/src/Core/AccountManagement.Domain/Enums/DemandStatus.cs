using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.Enums
{
    public enum DemandStatusEnum : int
    {
        [Display(Name = "در حال انجام تراکنش")]
        DoingTransaction = 1,

        [Display(Name = "تراکنش انجام شده")]
        DoneTransaction = 2,

        [Display(Name = "سپرده ندارد")]
        NotExistAccount = 3,

        [Display(Name = "حسابی با نوع موردنظر یافت نشد")]
        NoMatchedAccount = 4,
    }
}
