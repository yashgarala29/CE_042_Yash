using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_4
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            using (studentDataContext studentDataContext=new studentDataContext())
            {
                int id_del = int.Parse(sid.Text.ToString());
                student1 stu = studentDataContext.student1s.SingleOrDefault(x => x.sid == id_del);
                if(stu==null)
                {
                    Label1.Text = "pleas enter valid input";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else {
                    Label1.Text = "";
                studentDataContext.student1s.DeleteOnSubmit(stu);
                studentDataContext.SubmitChanges();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}