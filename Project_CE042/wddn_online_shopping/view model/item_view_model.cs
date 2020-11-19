using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.view_model
{
    public class item_view_model
    {
        public int product_id { get; set; }
        [Required]
        [Display(Name = "product Name")]
        public String product_name { get; set; }
        [Required]
        [Display(Name = "quantity")]
        public int product_quantity { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int product_price { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description ")]
        public String product_description { get; set; }
        [Required]
        [Display(Name = "Product image")]
        public IFormFile product_image { get; set; }

    }
}
