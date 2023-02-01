using AccountManagement.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface ITransactionService
    {
        Task<Guid> Add(AddTransactionRequest request);
        Task SetAccountBlockTransaction(SetAccountBlockTransactionRequest request);
        Task SetWithdrawBlockTransaction(SetWithdrawBlockTransactionRequest request);
    }
}
