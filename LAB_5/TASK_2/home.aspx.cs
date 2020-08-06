using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_2
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"]!=null)
            {

                Label1.Text = Session["name"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("order.aspx");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedItem.Value.Equals("electronic"))
            {
                item.Items.Clear();
                ListItem laptop = new ListItem("laptop", "50000");
                ListItem Smartphone = new ListItem("Smartphone", "10000");
                ListItem Pen_drive = new ListItem("Pen_drive", "500");
                ListItem calculator = new ListItem("calculator", "200");
                item.Items.Add(laptop);
                item.Items.Add(Smartphone);
                item.Items.Add(Pen_drive);
                item.Items.Add(calculator);
            }
            else
            {
                item.Items.Clear();
                ListItem meluha = new ListItem("Meluha", "250");
                ListItem nagas = new ListItem("Nagas", "300");
                ListItem gita = new ListItem("Gita", "500");
                ListItem ramayan = new ListItem("Ramayan", "550");
                item.Items.Add(meluha);
                item.Items.Add(gita);
                item.Items.Add(nagas);
                item.Items.Add(ramayan);
            }
        }
        Dictionary<string, int> dict = new Dictionary<string, int>();
        protected void item_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int price=Int32.Parse(item.SelectedValue);
            string book_name = item.SelectedItem.Text.ToString();
            temp.Text = book_name;
            if (dict.ContainsKey(book_name))
            {
                dict.Add(book_name, dict[book_name] +price);
                Session[book_name] = dict[book_name] + price;
            }
            else
            {
                Session[book_name] = price;
                dict.Add(book_name, price);
            }
        }
    }
}