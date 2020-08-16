using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            string username_take = username.Text;
            string password_take = password.Text;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT * FROM [user] where username=@0";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@0", username_take);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if(dataReader.Read())
            {
                Session["username"] = dataReader.GetValue(0).ToString();
                Response.Redirect("order.aspx");
            }
            else
            {
                Label1.Text = "pleas enter valid username or password";
                Label1.ForeColor = System.Drawing.Color.Red;
            }


        }
    }
}