using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Dto
{
    public class MatchNationalCodeWithDepositNumberProxyRequest
    {
        public string NationalCode { get; set; }
        public string DepositOrIbanNumber { get; set; }
    }
}
