using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Framework.Api.ApiResult
{
    public enum ApiResultStatusCode
    {
        [Display(Name = "عملیات با موفقیت انجام شد")]
        Success = 0,

        [Display(Name = "خطایی در سرور رخ داده است")]
        ServerError = 1500,

        [Display(Name = "پارامتر های ارسالی معتبر نیستند")]
        BadRequest = 1300,

        [Display(Name = "یافت نشد")]
        NotFound =1400,

        [Display(Name = "خطایی در پردازش رخ داد")]
        LogicError = 1600,

        [Display(Name = "خطای احراز هویت")]
        UnAuthorized = 1401
    }
}
