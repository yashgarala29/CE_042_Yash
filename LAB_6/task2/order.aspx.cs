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
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT * FROM [order]";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListItem item = new ListItem(dataReader.GetValue(1).ToString(), dataReader.GetValue(0).ToString());
                ListBox1.Items.Add(item);
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("product.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selected_item = ListBox1.SelectedItem.Text;
            string selected_value = ListBox1.SelectedItem.Value;
            string user = Session["username"].ToString();
            Session[selected_item] = selected_value;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString=WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "INSERT INTO [product] (username,pid) VALUES (@username,@pid)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pid", selected_value);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
    }
}