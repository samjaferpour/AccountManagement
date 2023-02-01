using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Contract.Enums
{
    public enum BankAccountStatus
    {
        [Display(Name = "فعال")]
        Active = 0,

        [Display(Name = "غیر فعال")]
        Inactive = 0,
    }
}
