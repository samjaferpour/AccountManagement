using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Framework.Api.ApiResult;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagementApi.Controllers.v1
{
    [Route("api/v{version:apiversion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1")]

    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        /// <summary>
        /// لیست نوع مالکیت حساب 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ApiResult<GetAccountOwnershipTypeResponse>> GetAccountOwnershipTypes()
        {
            var OwnershipType = await _accountService.GetAccountOwnershipTypes();
            return Ok(OwnershipType);

        }
        
        /// <summary>
        /// لیست وضعیت اشتراک
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ApiResult<GetSubscriptionTypesResponse>> GetSubscriptionTypes()
        {
            var SubscriptionTypeList = await _accountService.GetSubscriptionTypes();
            return Ok(SubscriptionTypeList);
        }
       
        /// <summary>
        /// لیست نوع ارز 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ApiResult<GetSwiftTypesResponse>> GetSwiftTypes()
        {
            var swiftTypes = await _accountService.GetSwiftTypes();
            return Ok(swiftTypes);
        }

    }
}
