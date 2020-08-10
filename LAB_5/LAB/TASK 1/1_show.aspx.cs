using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK1
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie httpCookie = Request.Cookies["date"];
            if(httpCookie==null)
            {
                Label1.Text = "no cookies found";
            }
            else
            {
                Label1.Text = "name " + httpCookie["name_c"];
                Label2.Text = "birthady " + httpCookie["date_c"];
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["date"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}