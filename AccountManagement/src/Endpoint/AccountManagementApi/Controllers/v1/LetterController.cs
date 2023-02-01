using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Framework.Api.ApiResult;
using Common.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace AccountManagementApi.Controllers.v1
{

    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class LetterController : ControllerBase
    {
        private readonly ILetterService _letterService;
        private readonly IValidator<GenerateTrackingCodeRequest> _validator;

        public LetterController(ILetterService letterService, IValidator<GenerateTrackingCodeRequest> validator)
        {
            this._letterService = letterService;
            this._validator = validator;
        }
        /// <summary>
        /// افزودن نامه و شروع روال بلاک کردن
        /// </summary>
        /// <param name="request">اطلاعات نامه و جزئیات نامه</param>
        /// <returns></returns>
        /// <exception cref="BadRequestException">در صورتی که ورودی نامعتبر باشد</exception>
        [HttpPost]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ApiResult<GenerateTrackingCodeResponse>> GenerateTrackingCode([FromBody] GenerateTrackingCodeRequest request)
        {
            var validatorResult = _validator.Validate(request);
            if (!validatorResult.IsValid)
            {
                throw new BadRequestException(validatorResult.Errors[0].ToString());
            }
            var trackingCode = await _letterService.GenerateTracking(request);
            return Ok(trackingCode);
        }

        /// <summary>
        /// لیست نوع نامه ها
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ApiResult<GetLetterTypeResponse>> GetLetterTypes()
        {
            var letterType = await _letterService.GetLetterTypes();
            return Ok(letterType);

        }
        

        /// <summary>
        /// درصد پیشرفت روال نامه
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ActionResult<GetLetterProgressResponse>> GetLetterProgress([FromBody] GetLetterProgressRequest request)
        {
            var progressInfo = await _letterService.GetLetterProgress(request);
            return Ok(progressInfo);
        }
        /// <summary>
        /// گزاش حساب های بلاک شده
        /// </summary>
        /// <param name="request">کد رهگیری</param>
        /// <returns></returns>
        [HttpPost]
        [MapToApiVersion("1")]
        [EnableCors("FrontEndPolicy")]
        public async Task<ActionResult<GetBlockTransactionsResponse>> GetBlockTransactions([FromBody] GetBlockTransactionsRequest request)
        {
            var blockTransactionsResponse = await _letterService.GetBlockTransactions(request);
            return Ok(blockTransactionsResponse);
        }
    }
}
