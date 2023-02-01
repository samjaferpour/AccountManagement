namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class BlockWithdrawProxyResponse
    {
        public bool IsSuccess { get; set; }
        public int RsCode { get; set; }
        public string Message { get; set; }
        public string BlockOrUnBlockLetterId { get; set; }
        public string TransactionDate { get; set; }
    }
}
