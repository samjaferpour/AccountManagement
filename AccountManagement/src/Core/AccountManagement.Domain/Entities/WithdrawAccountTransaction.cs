namespace AccountManagement.Domain.Entities
{
    public class WithdrawAccountTransaction
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string TraceNumber { get; set; }
        public string Date { get; set; }
        public Guid AccountId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatorId { get; set; }
        public Account Account { get; set; }
    }
}
