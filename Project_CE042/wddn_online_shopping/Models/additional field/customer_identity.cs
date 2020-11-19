using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.Models.additional_field
{
    public class customer_identity: IdentityUser
    {
        public String customer_name { get; set; }
        public String customer_email { get; set; }
        public int customer_mobile_no { get; set; }
        public string customer_address { get; set; }
        
        public String seller_name { get; set; }
        public String seller_email { get; set; }
        public int seller_mobile_no { get; set; }
        public string seller_shop_address { get; set; }

        public string account_type { get; set; }

    }
}
