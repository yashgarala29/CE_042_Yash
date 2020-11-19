using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.view_model
{
    public class customer_view_model
    {
        [Required]
        [Display(Name = "Name")]
        public String customer_name { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "please enter valid email ")]
        public String customer_email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String customer_password { get; set; }
        [Required]
        [Display(Name = "confirm password")]
        [DataType(DataType.Password)]
        [Compare("customer_password"
        , ErrorMessage = "password and confirm password must be same")]
        public String customer_confirm_password { get; set; }
        [Required]
        [Display(Name = "Mobile number")]
        [DataType(DataType.Text)]
        public int customer_mobile_no { get; set; }
        [Required]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string customer_address { get; set; }

        public IFormFile customer_image { get; set; }

    }
}
