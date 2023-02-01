using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.Enums
{
    public enum AccountOwnershipTypeEnum
    {
        [Display(Name = "حقیقی")]
        RealCustomer = 1,

        [Display(Name = "حقوقی")]
        LegalCustomer = 2,
    }
}
