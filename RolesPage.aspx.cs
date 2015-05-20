using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;

public partial class RolesPage : System.Web.UI.Page
{
    RolesForSession rpg = new RolesForSession();

    protected void Page_Load(object sender, EventArgs e)
    {

        CreateGrid();

        
    }
    protected void idCreateBtn_Click(object sender, EventArgs e)
    {
        rpg.CreateRole(idTextbox.Text);
        CreateGrid();
    }
 
    protected void idDeleteBtn_Click(object sender, EventArgs e)
    {
        rpg.DeleteRole(idTextbox.Text);
        CreateGrid();
    }
  

    void CreateGrid()
    {
        RepeaterRoles.DataSource = rpg.GetAllRoles();
        RepeaterRoles.DataBind();
        lblAmountRolesCount.Text = rpg.CountAllRoles().ToString();
    }
}