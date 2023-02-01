using AccountManagement.Contract.Dto;
using AccountManagement.Domain.Entities;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface ILetterService
    {
        Task AddLetterAsync(Letter letter);
        Task<FindLetterByIdResponse> FindLetterById(FindLetterByIdRequest request);
        Task<GenerateTrackingCodeResponse> GenerateTracking(GenerateTrackingCodeRequest request);
        Task<GetLetterTypeResponse> GetLetterTypes();
        Task<Guid> GetLetterIdByTrackingCode(Guid trackingCode);
        Task<GetLetterProgressResponse> GetLetterProgress(GetLetterProgressRequest request);
        Task<GetBlockTransactionsResponse> GetBlockTransactions(GetBlockTransactionsRequest request);
    }
}
