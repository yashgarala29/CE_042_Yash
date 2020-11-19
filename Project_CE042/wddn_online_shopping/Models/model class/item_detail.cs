using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wddn_online_shopping.Models.model_class
{
    public class item_detail
    {
        [Key]
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
        public String product_image { get; set; }
         [ForeignKey("seller_id")]
            public int seller_id { get; set; }
             public seller seller { get; set; }

        public ICollection<customer> buyers_list { get; set;}
        public ICollection<customer_cart_item> customer_cart_list { get; set; }
        //public ICollection<order> order { get; set; }
        ////[ForeignKey("seller_id")]
        //[ForeignKey("seller_id")]


    }
}
