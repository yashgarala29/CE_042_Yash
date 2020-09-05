using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_4
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (studentDataContext studentDataContext1 =new studentDataContext())
            {
                try { 
                student1 student = studentDataContext1.student1s.SingleOrDefault
                    (x => x.sid == int.Parse(sid.Text.ToString()));
                if(student ==null)
                {
                        Label1.Text = "pleas enter valid input";
                        Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                    { 
                 name.Text = student.name;
                cpi.Text = student.cpi;
                sem.Text = student.sem;
                contacno.Text = student.contactno;
                emailid.Text = student.emailid;
                    }
                }
                catch(System.NullReferenceException  err)
                {
                    Label1.Text = "pleas enter valid input";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (studentDataContext studentDataContext1 = new studentDataContext())
            {
                student1 student = studentDataContext1.student1s.SingleOrDefault
                    (x => x.sid == int.Parse(sid.Text.ToString()));
                student.name= name.Text;
                student.cpi= cpi.Text;
                student.sem= sem.Text ;
                student.contactno= contacno.Text ;
                student.emailid= emailid.Text;
                studentDataContext1.SubmitChanges();

            }
        }
    }
}