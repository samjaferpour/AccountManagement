using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Dto.Setting
{
    public class SiteSetting
    {
        public AppSetting AppSettings { get; set; }
        public DotinConfig DotinConfig { get; set; }
    }
}
