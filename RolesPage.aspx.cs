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
        

        string roleToCheck = idTextbox.Text.ToUpper();

        if (!rpg.CheckIfRoleExists(roleToCheck))
        {
            lblRoleInputConfirm.Text = "Ordet " + roleToCheck + " blev tilføjet!";
            lblRoleInputConfirm.ForeColor = System.Drawing.Color.Green;

            rpg.CreateRole(roleToCheck);
            CreateGrid();

            idTextbox.Text = "";
        }
        else
        {
            lblRoleInputConfirm.Text = "Ordet " + roleToCheck + " eksisterer allerede";
            lblRoleInputConfirm.ForeColor = System.Drawing.Color.Red;
        }
    }
 
    protected void idDeleteBtn_Click(object sender, EventArgs e)
    {
        string roleToCheck = idTextbox.Text.ToUpper();

        if (rpg.CheckIfRoleExists(roleToCheck))
        {
            lblRoleInputConfirm.Text = "Ordet " + roleToCheck + " blev slettet!";
            lblRoleInputConfirm.ForeColor = System.Drawing.Color.Green;

            rpg.DeleteRole(roleToCheck);
            CreateGrid();

            idTextbox.Text = "";
        }
        else
        {
            lblRoleInputConfirm.Text = "Ordet " + roleToCheck + " kunne ikke findes";
            lblRoleInputConfirm.ForeColor = System.Drawing.Color.Red;
        }
    }
  

    void CreateGrid()
    {
        RepeaterRoles.DataSource = rpg.GetAllRoles();
        RepeaterRoles.DataBind();
        lblAmountRolesCount.Text = rpg.CountAllRoles().ToString();
    }
}