using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class WSRequestGetAccountBalance
    {
        public string DepositNumber { get; set; }=String.Empty;
    }
}
