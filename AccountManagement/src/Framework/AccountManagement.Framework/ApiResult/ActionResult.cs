using Newtonsoft.Json;

namespace AccountManagement.Framework.ApiResult
{
    public class ActionResult
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public object Data { get; set; }
        //public ActionResult(bool isSuccess, int statusCode, string message = null, object data = null)
        //{
        //    IsSuccess = isSuccess;
        //    StatusCode = statusCode;
        //    Message = message;
        //    Data = data;
        //}
        public ActionResult(bool isSuccess, int statusCode, string message = null)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Message = message;
        }
    }
    public class ActionResult<TData> : ActionResult
    where TData : class
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TData Data { get; set; }

        public ActionResult(bool isSuccess, int statusCode, TData data, string message = null)
            : base(isSuccess, statusCode, message)
        {
            Data = data;
        }
        #region Implicit Operators
        public static implicit operator ActionResult<TData>(TData data)
        {
            return new ActionResult<TData>(true,0, data);
        }
       
        #endregion
    }
}

