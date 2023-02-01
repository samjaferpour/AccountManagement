using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccountManagement.Contract.Enums
{
    public enum BlockAccountStatus
    {
        [Display(Name = "موفق")]
        Successful = 0,

        [Display(Name = "ناموفق")]
        Unsuccessful = 1,

        [Display(Name = "تلاش مجدد")]
        Retry = 2,
    }
    
}
