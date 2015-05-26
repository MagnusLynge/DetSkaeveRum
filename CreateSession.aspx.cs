using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

public partial class CreateSession : System.Web.UI.Page
{
    ImagesForSession img = new ImagesForSession();
    WordForSession wrd = new WordForSession();
    RolesForSession rol = new RolesForSession();
    CreateSes newSes = new CreateSes();

    protected void Page_Load(object sender, EventArgs e)
    {
        repImagesOnSes.DataSource = img.GetAllImages();
        repImagesOnSes.DataBind();

        repWordsOnSes.DataSource = wrd.GetAllWords();
        repWordsOnSes.DataBind();

        repRolesOnSes.DataSource = rol.GetAllRoles();
        repRolesOnSes.DataBind();
    }

    protected void btnCreateSession_Click(object sender, EventArgs e)
    {
        var userID = User.Identity.GetUserId();
        newSes.CreateNewSession(Convert.ToInt32(userID), true);


        
    }





}