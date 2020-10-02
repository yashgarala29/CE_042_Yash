using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_9_NEW.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        
        [Display(Name = "Customer ID")]
        public int customer_id { get; set;}
        [ForeignKey("customer_id")]
        public Customer Customer { get; set; }
        
        [Display(Name = "Product ID")]
        public int product_id { get; set;}
        [ForeignKey("product_id")]
        public Product Product{get; set;}
        
        [Display(Name = "Total Amount")]
        [Required(ErrorMessage = "Amount is requrired fild")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "Price must be Greter than 0")]
        public float amount { get; set;}
        [OrderDate]
        [Required(ErrorMessage = "Order Date is requrired fild")]
        public DateTime order_date { get; set;}
    }
}
