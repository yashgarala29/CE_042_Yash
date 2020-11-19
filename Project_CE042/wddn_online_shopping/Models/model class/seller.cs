using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.Models.model_class
{
    public class seller
    {
        [Key]
        public int seller_id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public String seller_name { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "please enter valid email ")]
        public String seller_email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String seller_password { get; set; }
        [Required]
        [Display(Name = "confirm password")]
        [DataType(DataType.Password)]
        [Compare("seller_password"
        , ErrorMessage = "password and confirm password must be same")]
        public String seller_confirm_password { get; set; }
        [Required]
        [Display(Name = "Mobile number")]
        [DataType(DataType.Text)]
        public int seller_mobile_no { get; set; }
        [Required]
        [Display(Name = "shop Address")]
        [DataType(DataType.MultilineText)]
        public string seller_shop_address { get; set; }

        public String seller_image { get; set; }

        
        public static implicit operator seller(int v)
        {
            throw new NotImplementedException();
        }
    }
}
