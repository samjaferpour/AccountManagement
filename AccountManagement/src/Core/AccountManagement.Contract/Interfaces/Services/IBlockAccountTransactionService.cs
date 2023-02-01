﻿using AccountManagement.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface IBlockAccountTransactionService
    {
        Task<Guid> Add(AddBlockAccountTransactionRequest request);
        Task<GetBlockTransactionByAccountIdResponse> GetByAccountId(GetBlockTransactionByAccountIdRequest request);
    }
}
