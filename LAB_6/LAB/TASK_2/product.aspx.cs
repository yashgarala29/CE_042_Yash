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
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label l = new Label();
            // l.Text = "5555";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            
            
            Label total_price = new Label();
            int total = 0;
            String price = "total is";
            // form1.Controls.Add(l);
            foreach (var item in Session)
            {
                TableRow tableRow = new TableRow();
                TableCell tableCell = new TableCell();
                TableCell tableCell1 = new TableCell();
                Label l = new Label();
                int i = 0;
                if (int.TryParse(Session[item.ToString()].ToString(), out i))
                {
                    string query = "SELECT * FROM [order] where pid=@0";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@0", Int32.Parse(Session[item.ToString()].ToString()));
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    dataReader.Read();

                    total += int.Parse(dataReader.GetValue(3).ToString());
                    l.Text = item.ToString() + "   " + dataReader.GetValue(3).ToString().ToString();
                    tableCell.Text = item.ToString();
                    tableCell1.Text = dataReader.GetValue(3).ToString();
                    tableRow.Cells.Add(tableCell);
                    tableRow.Cells.Add(tableCell1);
                    Table1.Rows.Add(tableRow);
                    connection.Close();
                    //form1.Controls.Add(l);
                    //form1.Controls.Add(new LiteralControl("<br/>"));
                }
            }
            price = price + "  " + total;
            total_price.Text = price;
            form1.Controls.Add(total_price);

        }

    }
}