using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Contract.Enums
{
    public enum CustomerType
    {
        [Display(Name = "حقیقی ایرانی")]
        RealCustomer = 1,

        [Display(Name = "حقوقی ایرانی")]
        LegalCustomer = 2,

        [Display(Name = "حقیقی اتباع خارجی")]
        ForeignRealCustomer = 3,

        [Display(Name = "حقوقی اتباع خارجی")]
        ForeignLegalCustomer = 4,
    }
}
