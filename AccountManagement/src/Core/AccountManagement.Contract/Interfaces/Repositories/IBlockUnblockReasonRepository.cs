using AccountManagement.Contract.Dto;
using AccountManagement.Domain.Entities;


namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface IBlockUnblockReasonRepository
    {
        Task<int> InsertAsync(BlockUnblockReason blockUnblockReason);
        Task<List<BlockUnblockReason>> GetBlockUnblockReasonsAsync();
    }
}
