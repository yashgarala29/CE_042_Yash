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
                    cmd.ExecuteNonQuery();
                }
                
            //         con.Close();
            }catch(Exception err)
            {
                Response.Write(err.Message);
            }
        }
    }
}