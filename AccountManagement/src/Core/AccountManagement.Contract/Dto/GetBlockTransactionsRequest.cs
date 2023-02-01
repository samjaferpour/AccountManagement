using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Dto
{
    public class GetBlockTransactionsRequest
    {
        public Guid TrackingCode { get; set; }
    }
}
