using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pass = password.Text;
            string user = username.Text;
            if (pass.Equals("admin") && user.Equals("admin"))
            {
                Session["name"] = user;
                Response.Redirect("home.aspx");
            }
            else
            {
                Label1.Text = "please enter valid username or password";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}