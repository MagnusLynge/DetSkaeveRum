using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateSession : System.Web.UI.Page
{
    ImagesForSession img = new ImagesForSession();
    WordForSession wrd = new WordForSession();
    RolesForSession rol = new RolesForSession();

    protected void Page_Load(object sender, EventArgs e)
    {
        repImagesOnSes.DataSource = img.GetAllImages();
        repImagesOnSes.DataBind();

        repWordsOnSes.DataSource = wrd.GetAllWords();
        repWordsOnSes.DataBind();

        repRolesOnSes.DataSource = rol.GetAllRoles();
        repRolesOnSes.DataBind();
    }





}