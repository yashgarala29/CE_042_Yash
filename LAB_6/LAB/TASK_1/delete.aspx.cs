using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_1
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void delet_data_Click(object sender, EventArgs e)
        {
            try
            { 

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (con)
                {
                    string query = "DELETE FROM Student  WHERE id='" + id.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    int test=cmd.ExecuteNonQuery();
                    if(test==0)
                    {
                        Label1.Text = "data not found.";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        Label1.Text = "data is deleted successfully.";
                        Label1.ForeColor = System.Drawing.Color.Green;

                    }

                }
                
            //         con.Close();
            }catch(Exception err)
            {
                Response.Write(err.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insert.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("show.aspx");
        }
    }
}