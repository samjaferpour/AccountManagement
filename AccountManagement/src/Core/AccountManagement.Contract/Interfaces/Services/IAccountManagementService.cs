using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface IAccountManagementService
    {
        Task<GetBlockUnblockReasonResponse> GetBlockUnblockReasonListAsync();
        
        Task<BlockAccountStatus> BlockAccount(BlockAccountRequest request);
        Task<BlockWithdrawStatus> BlockWithdraw(BlockWithdrawRequest request);
    }
}
