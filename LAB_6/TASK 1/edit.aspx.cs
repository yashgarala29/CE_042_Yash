using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_1
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int givenid=Int32.Parse(given_id.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT * FROM STUDENT WHERE ID =" + givenid.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            id.Text= dataReader.GetValue(0).ToString();
            name.Text=dataReader.GetValue(1).ToString();
            sem.Text = dataReader.GetValue(2).ToString();
            mobile_no.Text = dataReader.GetValue(3).ToString();
            email.Text = dataReader.GetValue(4).ToString();
        }

        protected void show_Click(object sender, EventArgs e)
        {
            string id_take = id.Text;
            string name_take = name.Text;
            string mobile_no_take = mobile_no.Text;
            string sem_take = sem.Text;
            string email_take = email.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "UPDATE STUDENT SET NAME=@0, MOBILE_NO=@1,EMAIL_ID =@2,SEM =@3 WHERE Id=@4";
          //      "UPDATE STUDENT SET NAME=" +name_take+"mobile_no="+mobile_no_take+"" +
          //"email_id="+email_take+"sem="+sem_take+"where id="+id_take ;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@0", name_take);
            cmd.Parameters.AddWithValue("@3",sem_take);
            cmd.Parameters.AddWithValue("@1", mobile_no_take);
            cmd.Parameters.AddWithValue("@2", email_take);
            cmd.Parameters.AddWithValue("@4", id_take);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            //cmd.ExecuteNonQuery();
        }
    }
}