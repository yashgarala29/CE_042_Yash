using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
           // if (!IsPostBack)
            {
                if (state.Text.Equals("Maharastra"))
                {
                    city.Items.Clear();
                    ListItem Mumbai = new ListItem("Mumbai", "1");
                    ListItem Pune = new ListItem("Pune", "2");
                    city.Items.Add(Mumbai);
                    city.Items.Add(Pune);
                    //city.Items.FindByValue("Ahmedabad").Enabled=false;
                    //city.Items.FindByValue("Vadodara").Enabled = false;
                }
                else
                {
                    city.Items.Clear();
                    ListItem Ahmedabad = new ListItem("Ahmedabad", "3");
                    ListItem Vadodara = new ListItem("Vadodara", "4");
                    city.Items.Add(Ahmedabad);
                    city.Items.Add(Vadodara);

                    //city.Items.FindByValue("Mumbai").Enabled = false;
                    //city.Items.FindByValue("Pune").Enabled = false;
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = name.Text;
            Label2.Text = age.Text;
            Label3.Text = password.Text;
            Label4.Text = Gender.SelectedItem.Value.ToString();
            Label5.Text = mo_number.Text;
            string s= "";
            foreach (ListItem item in hobbies.Items)
            {
                if(item.Selected)
                {
                    s += " "+item.Text;
                }
            }
            Label6.Text = s;
            Label7.Text = state.Text;
            Label8.Text = city.Text;
            Label9.Text = pan_number.Text;//pelethi sikhavad ek navi file banav trial.aspx thi
        }

        protected void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}