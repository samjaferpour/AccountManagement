using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Service.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public async Task<Guid> Add(AddTransactionRequest request)
        {
            var transaction = new Transaction
            {
                AccountBlockingStatusCode = request.AccountBlockingStatusCode,
                AccountBlockingStatusDescription = request.AccountBlockingStatusDescription,
                AccountBlockingTraceNumber = request.AccountBlockingTraceNumber,
                WithdrawBlockingStatusCode = request.WithdrawBlockingStatusCode,
                WithdrawBlockingStatusDescription = request.WithdrawBlockingStatusDescription,
                WithdrawBlockingTraceNumber = request.WithdrawBlockingTraceNumber,
                AccountId = request.AccountId,
            };
            var transactionId = await _transactionRepository.InsertAsync(transaction);
            return transactionId;
        }
        public async Task<Transaction> FindById(Guid id)
        {
            return await _transactionRepository.FindById(id);
        }
        public async Task SetAccountBlockTransaction(SetAccountBlockTransactionRequest request)
        {
            var transaction = await FindById(request.Id);

            transaction.AccountBlockingStatusCode = request.AccountBlockingStatusCode;
            transaction.AccountBlockingStatusDescription = request.AccountBlockingStatusDescription;
            transaction.AccountBlockingTraceNumber = request.AccountBlockingTraceNumber;
            transaction.AccountBlockingDate = request.AccountBlockingDate;

            _transactionRepository.Update(transaction);
        }
        public async Task SetWithdrawBlockTransaction(SetWithdrawBlockTransactionRequest request)
        {
            var transaction = await FindById(request.Id);

            transaction.WithdrawBlockingStatusCode = request.WithdrawBlockingStatusCode;
            transaction.WithdrawBlockingStatusDescription = request.WithdrawBlockingStatusDescription;
            transaction.WithdrawBlockingTraceNumber = request.WithdrawBlockingTraceNumber;
            transaction.WithdrawBlockingDate = request.WithdrawBlockingDate;

            _transactionRepository.Update(transaction);
        }
    }
}
