using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pass= password.Text;
            string user = username.Text;
            if (pass.Equals("admin") && user.Equals("admin"))
            {
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