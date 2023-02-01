using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class WSRequestInquiryBrokerDepositNumber
    {
        public string Iban { get; set; } = String.Empty;
        public int BrokerId { get; set; }
    }
}
