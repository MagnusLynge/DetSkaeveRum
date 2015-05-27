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
        foreach (RepeaterItem i in repWordsOnSes.Items)
        {
            CheckBox chk = i.FindControl("checkWord") as CheckBox;
            if (chk.Checked)
            {
                var word = i.FindControl("lblWordSes") as Label;
                var wrdID = wrd.GetWordId(word.Text);
                mToM.AddWordsToSession(newSes.GetNewestSession(userID), Convert.ToInt32(wrdID));
            }
        }

        foreach (RepeaterItem i in repRolesOnSes.Items)
        {
            CheckBox chk = i.FindControl("checkRole") as CheckBox;
            if (chk.Checked)
            {
                var role = i.FindControl("lblRoleSes") as Label;
                var rolID = rol.GetRoleId(role.Text);
                mToM.AddRolesToSession(newSes.GetNewestSession(userID), Convert.ToInt32(rolID));
            }
        }

        Response.Redirect("AllMySessions.aspx");
    }
    protected void checkAllImgs_CheckedChanged(object sender, EventArgs e)
    {
        if (checkAllImgs.Checked)
        {
            foreach (RepeaterItem i in repImagesOnSes.Items)
            {
                CheckBox chk = i.FindControl("imgCheckBox") as CheckBox;
                chk.Checked = true;
            }
        }
        else if(!checkAllImgs.Checked)
        {
            foreach (RepeaterItem i in repImagesOnSes.Items)
            {
                CheckBox chk = i.FindControl("imgCheckBox") as CheckBox;
                chk.Checked = false;
            }
        }
    }
    protected void checkAllWrds_CheckedChanged(object sender, EventArgs e)
    {
        if (checkAllWrds.Checked)
        {
            foreach (RepeaterItem i in repWordsOnSes.Items)
            {
                CheckBox chk = i.FindControl("checkWord") as CheckBox;
                chk.Checked = true;
            }
        }
        else if (!checkAllWrds.Checked)
        {
            foreach (RepeaterItem i in repWordsOnSes.Items)
            {
                CheckBox chk = i.FindControl("checkWord") as CheckBox;
                chk.Checked = false;
            }
        }
    }
    protected void checkAllRols_CheckedChanged(object sender, EventArgs e)
    {
        if (checkAllRols.Checked)
        {
            foreach (RepeaterItem i in repRolesOnSes.Items)
            {
                CheckBox chk = i.FindControl("checkRole") as CheckBox;
                chk.Checked = true;
            }
        }
        else if (!checkAllRols.Checked)
        {
            foreach (RepeaterItem i in repRolesOnSes.Items)
            {
                CheckBox chk = i.FindControl("checkRole") as CheckBox;
                chk.Checked = false;
            }
        }
    }

}