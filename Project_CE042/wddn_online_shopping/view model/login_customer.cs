using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.view_model
{
    public class login_customer
    {
        [Required]
        [EmailAddress]
        public string customer_email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string customer_password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

    }
}
