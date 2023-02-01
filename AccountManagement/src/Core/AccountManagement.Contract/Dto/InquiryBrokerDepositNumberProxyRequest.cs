using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Dto
{
    public class InquiryBrokerDepositNumberProxyRequest
    {
        public String Iban { get; set; }
        public int ThirdPartyId { get; set; }
    }
}
