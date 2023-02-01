using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Enums;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Framework.Api.ApiResult;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagementApi.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class AccountManagementController : ControllerBase
    {
        private readonly IAccountManagementService _accountManagementService;
        public AccountManagementController(IAccountManagementService accountManagementService)
        {
            _accountManagementService = accountManagementService;
        }

        /// <summary>
        /// لیست دلیل مسدودی و رفع مسدودی
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ApiResult<GetBlockUnblockReasonResponse>> GetBlockUnblockReason()
        {
            var Reason = await _accountManagementService.GetBlockUnblockReasonListAsync();
            return Ok(Reason);

        }

        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<BlockAccountStatus> BlockAccount([FromBody] BlockAccountRequest request)
        {
            var blockInfo = await _accountManagementService.BlockAccount(request);
            return blockInfo;
        }
       
        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<BlockWithdrawStatus> BlockWithdraw([FromBody] BlockWithdrawRequest request)
        {
            var blockInfo = await _accountManagementService.BlockWithdraw(request);
            return blockInfo;
        }
    }
}
