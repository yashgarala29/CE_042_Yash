using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task3
{
    public partial class image : System.Web.UI.Page
    {
        static bool flag = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                Image1.Visible = true;
                flag = true;
            }
            else
            {
                Image1.Visible = false;
                flag = false;
            }
        }
    }
}