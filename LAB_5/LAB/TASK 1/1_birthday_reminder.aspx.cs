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
           
            
        }

        protected void remember_Click(object sender, EventArgs e)
        {
            
           
                HttpCookie httpCookie = new HttpCookie("date");
                httpCookie["name_c"] = Name.Text; 
                httpCookie["date_c"] = birthday.Text;
            httpCookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(httpCookie);
            Response.Redirect("show.aspx");
            
               
            
         }

        
    }
}