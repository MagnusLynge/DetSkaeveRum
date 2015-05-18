using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RolesPage : System.Web.UI.Page
{
    RolesForSession rpg;

    protected void Page_Load(object sender, EventArgs e)
    {
        rpg = new RolesForSession();

        CreateGrid();
    }
    protected void idCreateBtn_Click(object sender, EventArgs e)
    {
        rpg.CreateRole(idTextbox.Text);
        CreateGrid();
    }
    protected void idUpdateBtn_Click(object sender, EventArgs e)
    {
        rpg.UpdateRole(idTextbox.Text, idStringTextbox.Text);
        CreateGrid();
    }
    protected void idDeleteBtn_Click(object sender, EventArgs e)
    {
        rpg.DeleteRole(idTextbox.Text);
        CreateGrid();
    }
    protected void idGetSingleBtn_Click(object sender, EventArgs e)
    {
        var tempObj = rpg.GetRole(idTextbox.Text);
        idStringTextbox.Text = tempObj[0].Role1;
    }

    void CreateGrid()
    {
        GridView1.DataSource = rpg.GetAllRoles();
        GridView1.DataBind();
    }
}