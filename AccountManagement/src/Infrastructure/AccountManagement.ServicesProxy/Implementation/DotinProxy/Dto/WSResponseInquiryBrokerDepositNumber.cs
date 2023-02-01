using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class WSResponseInquiryBrokerDepositNumber
    {
        public bool IsSuccess { get; set; }
        public int RsCode { get; set; }
        public string Message { get; set; } = string.Empty;
        public DelegationData ResultData { get; set; }
        public List<DelegationErrorItem> ErrorList { get; set; }
    }
    public class DelegationData
    {
        public string DepositNumber { get; set; }
        public int BrokerId { get; set; }
        public int State { get; set; }
    }

    public class DelegationErrorItem
    {
        public int Code { get; set; }
        public string Desc { get; set; }
    }
}
