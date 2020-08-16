using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_1
{
    public partial class insert : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "INSERT INTO STUDENT (NAME,SEM,MOBILE_NO,EMAIL_ID) VALUES (@NAME,@SEM,@MOBILE,@EMAIL)";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NAME", name.Text);
                cmd.Parameters.AddWithValue("@SEM", Int64.Parse(sem.Text));
                cmd.Parameters.AddWithValue("@MOBILE", mobile.Text);
                cmd.Parameters.AddWithValue("@EMAIL", email.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "data is inserted successfully.";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception)
            {

                
            }
            
            //------------------------------------------------------------
             

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("delete.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("show.aspx");
        }
    }
}