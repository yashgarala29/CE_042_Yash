using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_online_shopping.Models.model_class
{
    public class order
    {
        //public order()
        //{
        //    this.customer_oreder = new HashSet<item_detail>();
        //}
        [Key]
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public int product_id { get; set; }
        public int seller_id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime order_date { get; set; }
        public string order_status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime delivery_date { get; set; }

        //public ICollection<item_detail> customer_oreder { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int total_pricer { get; set; }

    }
}
