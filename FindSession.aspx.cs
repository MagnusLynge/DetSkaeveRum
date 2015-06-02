using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FindSession : System.Web.UI.Page
{
    Sessions ses = new Sessions();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSes_Click(object sender, EventArgs e)
    {
        String sesName = txtSession.Text.ToUpper();
        int sesID = ses.getSessionIDByName(sesName);
        if (sesID != 0)
        {
            Response.Redirect("~/ActiveSession.aspx?id=" + sesID);
        }
        else
        {
            lblStatus.Visible = true;
        }
    }
}