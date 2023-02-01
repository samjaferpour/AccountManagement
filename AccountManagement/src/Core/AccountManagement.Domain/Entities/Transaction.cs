using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public int? AccountBlockingStatusCode { get; set; }
        public string AccountBlockingStatusDescription { get; set; }
        public string AccountBlockingTraceNumber { get; set; }
        public string AccountBlockingDate { get; set; }
        public int? WithdrawBlockingStatusCode { get; set; }
        public string WithdrawBlockingStatusDescription { get; set; }
        public string WithdrawBlockingTraceNumber { get; set; }
        public string WithdrawBlockingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatorId { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        //ToDo:برای ریفکتور حتما این جداول پاک بشه و به یه جدول تعریف بشه و از اون جدول وضعیت ها رو بخونه
        //public AccountBlockingStatus AccountBlockingStatus { get; set; }
        //public WithdrawBlockingStatus WithdrawBlockingStatus { get; set; }
    }
}
