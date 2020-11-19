using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.Models.model_class
{
    public class customer_cart_item
    {
        public int id { get; set; }
        //[ForeignKey("customer_id")]
        //public int customer_id { get; set; }
        public customer customer { get; set; }
        //[ForeignKey("product_id")]
        //public int product_id { get; set; }
        public item_detail item_Detail { get; set; }


    }
}
