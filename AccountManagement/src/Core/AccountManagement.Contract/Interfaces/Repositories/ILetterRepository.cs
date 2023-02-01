using AccountManagement.Contract.Dto;
using AccountManagement.Domain.Entities;


namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface ILetterRepository
    {
        Task InsertAsync(Letter letter);
        Task<Letter> FindById(Guid id);
        Task<List<LetterType>> GetLetterTypes();
        Task<bool> IsExistTrackingCode(Guid trackingCode);
        Task<Guid> FindIdByTrackingCode(Guid trackingCode);
        Task<LetterProgressResponse> LetterProgress(Guid trackingCode);
        Task<bool> HasAnyDemand(Guid trackingCode);
        Task<GetBlockTransactionsResponse> GetBlockTransactions(GetBlockTransactionsRequest request);
    }
}
