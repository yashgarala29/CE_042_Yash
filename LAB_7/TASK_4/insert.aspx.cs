using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_4
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (studentDataContext studentDataContext=new studentDataContext())
            {
                String cpi_in = cpi.Text;
                String name_in = name.Text;
                String sem_in = sem.Text;
                String contacno_in = contacno.Text;
                String emailid_in = emailid.Text;

                student1 student = new student1
                {

                    cpi = cpi_in,
                    name = name_in,
                    contactno = contacno_in,
                    emailid = emailid_in,
                    sem = sem_in,

                };
                studentDataContext.student1s.InsertOnSubmit(student);
                studentDataContext.SubmitChanges();

            }
        }
    }
}