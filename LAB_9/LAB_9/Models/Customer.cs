using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_9.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        [Display(Name ="Customer Name")]
        [Required(ErrorMessage ="Name is requrired fild")]
        public string customer_name { get; set; }
        
        [Display(Name = "Customer Email")]
        [Required(ErrorMessage = "Email is requrired fild")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"
           ,ErrorMessage ="Please enter valid email")]
        public string customer_email { get; set;}
        
        [Display(Name = "Customer Mobile No")]
        [Required(ErrorMessage = "Mobile No is requrired fild")]
        [RegularExpression(@"^[0-9]{10}$"
           , ErrorMessage = "Please enter valid mobile number")]
        public int customer_mobile_number { get; set;}
        //public ICollection<Order> orders { get; set; }
        public IList<Order> orders { get; set; }
    }
}
