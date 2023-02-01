using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Domain.Entities;
using AccountManagement.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Persistence.Implimentation.Repositories
{
    public class LetterRepository : ILetterRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public LetterRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task InsertAsync(Letter letter)
        {
            await _dbcontext.Letters.AddAsync(letter);
        }
        public async Task<Letter> FindById(Guid id)
        {
            var letter = await _dbcontext.Letters
                .FirstOrDefaultAsync(p => p.Id == id);
            return letter;
        }
        public async Task<bool> IsExistTrackingCode(Guid trackingCode)
        {
            var isExist = await _dbcontext.Letters
                .AnyAsync(p => p.TrackingCode == trackingCode);
            return isExist;
        }
        public async Task<Guid> FindIdByTrackingCode(Guid trackingCode)
        {
            var letter = await _dbcontext.Letters
                .FirstOrDefaultAsync(p => p.TrackingCode == trackingCode);
            return letter.Id;
        }
        public async Task<LetterProgressResponse> LetterProgress(Guid trackingCode)
        {
            var progressResponses = await _dbcontext.Letters
                 .Where(p => p.TrackingCode == trackingCode)
                .Include(x => x.DemandPackets)
                .Select(p => new LetterProgressResponse
                {
                    TotalCount = p.DemandCount,
                    DoneCount = p.DemandPackets
                   .Where(d => d.DemandStatusId != (int)DemandStatusEnum.DoingTransaction)
                   .Count(),
                }).FirstOrDefaultAsync();
            return progressResponses;
        }

        public async Task<List<LetterType>> GetLetterTypes()
        {
            var letterTypeList = await _dbcontext.LetterType
                 .OrderBy(o => o.Order)
                 .ToListAsync();
            return letterTypeList;
        }

        public async Task<bool> HasAnyDemand(Guid trackingCode)
        {
            return await _dbcontext.Letters
                .Where(p => p.TrackingCode == trackingCode)
               .Include(x => x.DemandPackets)
               .AnyAsync(x => x.DemandPackets.Any());
        }
        public async Task<GetBlockTransactionsResponse> GetBlockTransactions(GetBlockTransactionsRequest request)
        {
            var Letter = _dbcontext.Letters
                .Where(p => p.TrackingCode == request.TrackingCode)
                .Include(x => x.DemandPackets)
                .ThenInclude(x => x.Accounts)
                .ThenInclude(x => x.Customers)
                .ThenInclude(x => x.Account.BlockAccountTransaction)
                .ThenInclude(x => x.Account.WithdrawAccountTransaction);

                var transactionsResponse = await Letter
                   .Select(p => new GetBlockTransactionsResponse
                   {
                       TrackingCode = p.TrackingCode,
                       DemandItems = p.DemandPackets
                       .Where(x=>x.DemandStatusId !=(int)DemandStatusEnum.DoingTransaction)
                       .Select(x => new DemandItemDto
                       {
                           TraceCode = x.TraceCode,
                           AccountTransaction = x.Accounts.Select(c => new AccountTransaction
                           {
                               AccountNumber = c.Number,
                               Iban = c.Iban,
                               AccountType = c.TypeDescription,
                               ActualAmount = c.ActualAmount,
                               AvailableAmount = c.ActualAmount,
                               Customers = c.Customers.Select(g => new CustomerDto
                               {
                                   FirstName = g.FirstName,
                                   LastName = g.LastName,
                                   NationalCode = g.NationalCode,
                               }),
                               WithdrawAccountTransaction = new WithdrawAccountTransactionDto
                               {

                                   TraseNumber = c.WithdrawAccountTransaction.TraceNumber,
                                   Date = c.WithdrawAccountTransaction.Date,
                                   Description = c.WithdrawAccountTransaction.Description,
                                   Status = c.WithdrawAccountTransaction.Status
                               },

                               BlockAccountTransaction = new BlockAccountTransactionDto
                               {
                                   TraseNumber = c.BlockAccountTransaction.TraceNumber,
                                   Date = c.BlockAccountTransaction.Date,
                                   Description = c.BlockAccountTransaction.Description,
                                   Status = c.BlockAccountTransaction.Status
                               }
                           }),
                           DemandStatus = x.DemandStatusId,
                           DemandStatusTitle= x.DemandStatus.Title

                       })
                   }).FirstOrDefaultAsync();
            return transactionsResponse;
        }

    }
   
}
