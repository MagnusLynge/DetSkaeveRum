using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;



public partial class Admin_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CreateUser_Click(object sender, EventArgs e)
    {
        // Default UserStore constructor uses the default connection string named: DefaultConnection
        var userStore = new UserStore<IdentityUser>();
        var manager = new UserManager<IdentityUser>(userStore);
        var user = new IdentityUser() { UserName = UserName.Text };

        IdentityResult result = manager.Create(user, Password.Text);



        if (result.Succeeded)
        {
<<<<<<< HEAD
            StatusMessage.Text = string.Format("User {0} was created successfully!", user.UserName);
            //var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            //var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            //authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
            //Response.Redirect("~/Login.aspx");

=======
            lblRegisterError.Visible = false;
            lblRegisterSuccess.Visible = true;
            lblRegisterSuccess.Text = string.Format("User {0} Blev oprettet!", user.UserName);
>>>>>>> origin/login
        }
        else
        {
            lblRegisterSuccess.Visible = false;
            lblRegisterError.Visible = true;
            lblRegisterError.Text = result.Errors.FirstOrDefault();
        }
    }
}
