using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apps.Models
{
    public partial class AccountModel
    {

        public string Id { get; set; }

        public string UserName { get; set; }
        public string TrueName { get; set; }
        public string Photo { get; set; }

        public bool State { get; set; }

        public string Password { get; set; }

        public string[] HasMerchantCode;
        public bool AllMerchant { get; set; }
    }
}
