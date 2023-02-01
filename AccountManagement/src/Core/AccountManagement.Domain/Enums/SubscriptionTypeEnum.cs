using System.ComponentModel.DataAnnotations;


namespace AccountManagement.Domain.Enums
{
    public enum SubscriptionTypeEnum
    {
        [Display(Name = "انفرادی")]
        Single = 1,

        [Display(Name = "مشترک")]
        Copartnership = 2,

    }
}
