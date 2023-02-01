using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class WSResponseGetAccountBalance
    {
        public bool IsSuccess { get; set; }
        public int RsCode { get; set; }
        public string Message { get; set; } = string.Empty;
        public BalanceData ResultData { get; set; }
    }
    public class BalanceData
    {
        public string CurrentAmount { get; set; } = String.Empty;
        public string CurrentWithdrawableAmount { get; set; } = String.Empty;
    }
}
