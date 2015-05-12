using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    List<System.Web.UI.HtmlControls.HtmlGenericControl> controllist;

    System.Web.UI.HtmlControls.HtmlGenericControl activeselector = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        //controllist = new List<System.Web.UI.HtmlControls.HtmlGenericControl>();
        //controllist.Add(navhomelink);
        //controllist.Add(navaboutlink);
        //controllist.Add(navcontactlink);
        //navaboutlink.Attributes.Add("class", "active");
        if (activeselector == null)
            activeselector = navhomelink;
        activeselector.Attributes.Add("class", "active");
    }

    protected void navhomelink_click(object sender, EventArgs e)
    {
        activeselector = navhomelink;
    }

    protected void navaboutlink_click(object sender, EventArgs e)
    {
        activeselector = navaboutlink;
    }
}
