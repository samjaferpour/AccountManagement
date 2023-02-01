using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AccountManagement.Persistence.Implimentation.Repositories
{
    public class BlockUnblockReasonRepository : IBlockUnblockReasonRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public BlockUnblockReasonRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<BlockUnblockReason>> GetBlockUnblockReasonsAsync()
        {
            var data = await _dbcontext.BlockUnblockReasons
                .OrderBy(o=>o.Order)
                .ToListAsync();         
            return data;
        }

        public async Task<int> InsertAsync(BlockUnblockReason blockUnblockReason)
        {
            await _dbcontext.BlockUnblockReasons.AddAsync(blockUnblockReason);
            return blockUnblockReason.Id;
        }
    }
}
