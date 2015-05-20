using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var pageBtn = (HtmlGenericControl)Master.FindControl("navaboutlink");
        pageBtn.Attributes.Add("class", "active");
    }
}