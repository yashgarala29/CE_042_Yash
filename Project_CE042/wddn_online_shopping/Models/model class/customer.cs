using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.Models.model_class
{
    public class customer
    {
        [Key]
        public int customer_id { get; set;}
        [Required]
        [Display(Name ="Name")]
        public String customer_name { get; set;}
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage ="please enter valid email ")]
        public String customer_email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String customer_password { get; set;}
        [Required]
        [Display(Name = "confirm password")]
        [DataType(DataType.Password)]
        [Compare("customer_password"
        ,ErrorMessage = "password and confirm password must be same")]
        public String customer_confirm_password { get; set; }
        [Required]
        [Display(Name = "Mobile number")]
        [DataType(DataType.Text)]
        public int customer_mobile_no { get; set; }
        [Required]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string customer_address{ get; set; }
        
        public String customer_image{ get; set; }

        public ICollection<customer_cart_item> customer_cart { get; set; }
        //public ICollection<order> customer_order { get; set; }

        public ICollection<item_detail> customer_oreder { get; set; }


    }
}
