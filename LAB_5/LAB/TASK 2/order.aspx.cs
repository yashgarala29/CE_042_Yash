using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_2
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label l = new Label();
            // l.Text = "5555";
            Label total_price = new Label();
            int total = 0;
            String price = "total is";
           // form1.Controls.Add(l);
            foreach (var item  in Session)
            {
                Label l = new Label();
                total+=Int32.Parse(Session[item.ToString()].ToString());
                l.Text = item.ToString() +"   "+Session[item.ToString()].ToString();
                form1.Controls.Add(l);
                form1.Controls.Add(new LiteralControl("<br/>"));
            }
            price = price + "  " +total;
            total_price.Text = price;
            form1.Controls.Add(total_price);

        }
    }
}