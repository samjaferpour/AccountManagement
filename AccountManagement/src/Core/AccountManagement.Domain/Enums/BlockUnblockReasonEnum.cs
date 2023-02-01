using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.Enums
{
    public enum BlockUnblockReasonEnum : int
    {
        [Display(Name = "مفقودی")]
        lostCause = 1,
        [Display(Name = "دستورمسئولین شعبه/دستور ستاد")]
        branchAdminOrder = 2,
        [Display(Name = "دستور مقام قضائی")]
        judicialOrder = 3,
        [Display(Name = "دستور مقامات کیفری")]
        courtOrderCause = 4,
        [Display(Name = "دستورحفاظت")]
        keepOrderCause = 5,
        [Display(Name = "دستوراداره کل بودجه")]
        budgetOrganizationOrderCause = 6,
        [Display(Name = "بدحسابی مشتری")]
        illegalCustomerCause = 7,
        [Display(Name = "خیانت در امانت")]
        barratry = 8,
        [Display(Name = "کلاهبرداری")]
        Defraud = 9,
        [Display(Name = "مسروقه")]
        StolenCause = 10,
        [Display(Name = "جعل")]
        Fake = 11,
        [Display(Name = "انسداد به موجب ماده 21 قانون چک")]
        OBSTRUCTION_ACCORDING_TO_ARTICLE_21_OF_CHEQUE_LAW = 12,
        [Display(Name = "درخواست صدور چک الکترونیک")]
        electronicChequelssueRequest = 13,
        [Display(Name = "سایر")]
        OtherBlockCause = 14,
        [Display(Name = "پرداخت وجه چک برگشتی")]
        PayBouncedChequeAmount = 15,
        [Display(Name = "فاقد شناسه ملی اشخاص حقوقی")]
        withOutLegalNationalCode = 16,
        [Display(Name = "فاقد شناسه اختصاصی اتباع خارجی")]
        WithOutSpecificCodeForForeignPeople = 17,
        [Display(Name = "محرومیت لیست سیاه")]
        BlackListConstraint = 18,
        [Display(Name = "ترهین وثیقه")]
        TARHIN_E_VASIGHE = 19,
        [Display(Name = "رفع ترهین وثیقه")]
        RAFE_TARHINE_VASIGHE = 20,
        [Display(Name = "انسداد به موجب ماده 14 قانون چک")]
        OBSTRUCTION_ACCORDING_TO_ARTICLE_14_OF_CHEQUE_LAW = 21,
        
    }
}
