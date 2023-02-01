namespace AccountManagement.Contract.Dto
{
    public class BlockWithdrawProxyRequest
    {
        public string AccountNumber { get; set; }
        public string ReceiptLetterDate { get; set; }
        public string LetterTitle { get; set; }
        public string LetterContext { get; set; }
        public string LetterNumber { get; set; }
        public string LetterDate { get; set; }
        public string LetterDeadline { get; set; }
        public string? BlockOrUnblockPasword { get; set; }
        public string? LetterContextImage { get; set; }
        public string BlockReasonTitle { get; set; }
        public string SwiftCode { get; set; }
    }
}
