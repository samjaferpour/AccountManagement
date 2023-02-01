using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class WSRequestMatchNationalCodeWithDepositNumber
    {
        public string NationalId { get; set; } = string.Empty;
        public string DepositOrIbanNumber { get; set; } = string.Empty;
    }
}
