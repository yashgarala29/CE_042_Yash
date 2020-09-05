using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK_4
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            studentDataContext studentDataContext = new studentDataContext();
            var student_data = from student1 in studentDataContext.student1s
                               select student1;
            GridView1.DataSource = student_data;
            GridView1.DataBind();
        }
    }
}