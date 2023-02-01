using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Dto
{
    public class GetAccountBalanceProxyRequest
    {
        public string DepositNumber { get; set; } = String.Empty;
    }
}
