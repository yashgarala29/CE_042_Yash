using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_9_NEW.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Name is requrired fild")]
        public string Product_Name { get; set;}
        [Display(Name = "Product Detail")]
        [Required(ErrorMessage = "Detail is requrired fild")]
        public string Product_Detail { get; set;}
        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "Price is requrired fild")]
        [Range(minimum:1,maximum:double.MaxValue,ErrorMessage ="Price must be Greter than 0")]
        public string Product_Price { get; set;}
        //public ICollection<Order> orders { get; set; }
        public IList<Order> orders { get; set; }
    }
}
