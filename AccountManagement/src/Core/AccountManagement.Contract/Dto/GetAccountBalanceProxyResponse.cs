using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Dto
{
    public class GetAccountBalanceProxyResponse
    {
        public string CurrentAmount { get; set; } = String.Empty;
        public string CurrentWithdrawableAmount { get; set; } = String.Empty;
    }
}
