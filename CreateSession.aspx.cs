using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

public partial class CreateSession : System.Web.UI.Page
{
    ImagesForSession img = new ImagesForSession();
    WordForSession wrd = new WordForSession();
    RolesForSession rol = new RolesForSession();
    CreateSes newSes = new CreateSes();
    ManyToMany mToM = new ManyToMany();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            repImagesOnSes.DataSource = img.GetAllImages();
            repImagesOnSes.DataBind();

            repWordsOnSes.DataSource = wrd.GetAllWords();
            repWordsOnSes.DataBind();

            repRolesOnSes.DataSource = rol.GetAllRoles();
            repRolesOnSes.DataBind();
        }
    }

    protected void btnCreateSession_Click(object sender, EventArgs e)
    {
        var userID = User.Identity.GetUserId();
        newSes.CreateNewSession(userID, true, txtSesName.Text);

        foreach (RepeaterItem i in repImagesOnSes.Items)
        {
            CheckBox chk = i.FindControl("imgCheckBox") as CheckBox;

            if (chk.Checked)
            {
                var image = (System.Web.UI.WebControls.Image)i.FindControl("imgForSession");
                var imgUrl = image.ImageUrl;
                var imgID = img.GetImageId(imgUrl.Remove(0, 9));

                mToM.AddImagesToSession(newSes.GetNewestSession(userID), imgID);
            }
        }

    }

}