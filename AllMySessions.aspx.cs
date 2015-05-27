using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

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