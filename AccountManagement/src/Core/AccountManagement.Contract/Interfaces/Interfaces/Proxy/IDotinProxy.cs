using AccountManagement.Contract.Dto;
using AccountManagement.Framework.ApiResult;

namespace AccountManagement.Contract.Interfaces.Proxy
{
    public interface IDotinProxy
    {
        Task<ActionResult<GetCustomerInfoResponse>> GetCustomerInfo(GetCustomerInfoRequest request);
        Task<ActionResult<GetCustomerAccountsProxyResponse>> GetCustomerAccounts(GetCustomerAccountsProxyRequest request);
        Task<ActionResult<GetAccountInfoProxyResponse>> GetAccountInfo(GetAccountInfoProxyRequest request);
        Task<ActionResult<BlockAccountProxyResponse>> BlockAccount(BlockAccountProxyRequest request);
        Task<ActionResult<BlockWithdrawProxyResponse>> BlockWithdraw(BlockWithdrawProxyRequest request);
        Task<ActionResult> MatchNationalCodeWithDepositNumber(MatchNationalCodeWithDepositNumberProxyRequest request);
        Task<ActionResult<GetAccountBalanceProxyResponse>> GetAccountBalance(GetAccountBalanceProxyRequest request);
        Task<ActionResult<InquiryBrokerDepositNumberProxyResponse>> InquiryDelegationStatus(InquiryBrokerDepositNumberProxyRequest request);
    }
}