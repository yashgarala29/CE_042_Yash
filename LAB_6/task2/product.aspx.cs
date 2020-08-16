using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                    total += Int32.Parse(Session[item.ToString()].ToString());
                    l.Text = item.ToString() + "   " + Session[item.ToString()].ToString();
                    tableCell.Text = item.ToString();
                    tableCell1.Text = Session[item.ToString()].ToString();
                    tableRow.Cells.Add(tableCell);
                    tableRow.Cells.Add(tableCell1);
                    Table1.Rows.Add(tableRow);
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