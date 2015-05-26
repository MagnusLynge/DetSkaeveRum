﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Homepage.aspx");
            }
        }
    }

    protected void SignIn(object sender, EventArgs e)
    {
        var userStore = new UserStore<IdentityUser>();
        var userManager = new UserManager<IdentityUser>(userStore);
        var user = userManager.Find(UserName.Text, Password.Text);

        if (user != null)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

            authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
            Response.Redirect("~/Homepage.aspx");
        }
        else
        {
            //StatusText.Text = "Invalid username or password.";
            lblStatus.Visible = true;
        }
    }
}