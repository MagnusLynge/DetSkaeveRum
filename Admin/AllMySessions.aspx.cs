using System;
using Microsoft.AspNet.Identity;

namespace Admin
{
    public partial class AllMySessions : System.Web.UI.Page
    {
        Sessions ses = new Sessions();

        protected void Page_Load(object sender, EventArgs e)
        {
            var userID = User.Identity.GetUserId();
            RepeaterSesOnTeacher.DataSource = ses.GetAllSessionsOnTeacherID(userID);
            RepeaterSesOnTeacher.DataBind(); 
        }

    }
}