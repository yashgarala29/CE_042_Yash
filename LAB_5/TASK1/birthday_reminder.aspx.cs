using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK1
{
    public partial class birthday_reminder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie httpCookie1 = Request.Cookies["date"];
            if (httpCookie1!=null)
            {
                name_l.Text = httpCookie1["name_c"];
                date.Text = httpCookie1["date_c"];
                httpCookie1.Expires = DateTime.Now.AddMinutes(2);
                Response.Cookies.Add(httpCookie1);

            }
            else
            {
                name_l.Text = null;
                date.Text = null;

            }
        }

        protected void remember_Click(object sender, EventArgs e)
        {
            
           
                HttpCookie httpCookie = new HttpCookie("date");
                httpCookie["name_c"] = Name.Text; 
                httpCookie["date_c"] = birthday.Text;
                 name_l.Text = Name.Text;
                date.Text = birthday.Text;
            Response.Cookies.Add(httpCookie);
            
               
            
         }

        protected void delete_Click(object sender, EventArgs e)
        {
            HttpCookie httpCookie = new HttpCookie("date");
            httpCookie.Expires =DateTime.Now.AddMinutes(0);
      
                Response.Cookies.Add(httpCookie);
            
            
        }
    }
}