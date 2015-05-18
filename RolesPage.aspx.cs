using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RolesPage : System.Web.UI.Page
{
    Roles rpg;

    protected void Page_Load(object sender, EventArgs e)
    {
        rpg = new Roles();

        CreateGrid();
    }
    protected void idCreateBtn_Click(object sender, EventArgs e)
    {
        rpg.CreateRole(idStringTextbox.Text);
        CreateGrid();
    }
    protected void idUpdateBtn_Click(object sender, EventArgs e)
    {
        rpg.UpdateRole(Int32.Parse(idTextbox.Text), idStringTextbox.Text);
        CreateGrid();
    }
    protected void idDeleteBtn_Click(object sender, EventArgs e)
    {
        rpg.DeleteRole(Int32.Parse(idTextbox.Text));
        CreateGrid();
    }
    protected void idGetSingleBtn_Click(object sender, EventArgs e)
    {
        var tempObj = rpg.GetRole(Int32.Parse(idTextbox.Text));
        idStringTextbox.Text = tempObj[0].Role1;
    }

    void CreateGrid()
    {
        GridView1.DataSource = rpg.GetAllRoles();
        GridView1.DataBind();
    }
}