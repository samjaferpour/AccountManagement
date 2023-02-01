namespace AccountManagement.Contract.Dto
{
    public class FindLetterByIdResponse
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }
        public string ReceiptDate { get; set; }
        public string Content { get; set; }
        public string Deadline { get; set; }
        public Guid TrackingCode { get; set; }
        public int LetterTypeId { get; set; }
        public string? ContextImage { get; set; }
    }
}
