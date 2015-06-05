using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

public partial class ActiveSession : System.Web.UI.Page
{
    ManyToMany mtm = new ManyToMany();
    CreateSes newSes = new CreateSes();
    ImagesForSession imgSes = new ImagesForSession();
    RolesForSession rolSes = new RolesForSession();
    WordForSession wrdSes = new WordForSession();
    AudioForSession audSes = new AudioForSession();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (ImagesForSession().Count > 0 && RolesForSession().Count > 0 && WordsForSession().Count > 0)
            {
                repImgs.DataSource = ImagesForSession();
                repImgs.DataBind();
                repRol.DataSource = RolesForSession();
                repRol.DataBind();
                repWrd.DataSource = WordsForSession();
                repWrd.DataBind();
            }
            else if (ImagesForSession().Count > 0 && RolesForSession().Count > 0 && WordsForSession().Count <= 0)
            {
                repWrd.Visible = false;
                repImgs.DataSource = ImagesForSession();
                repImgs.DataBind();
                repRol.DataSource = RolesForSession();
                repRol.DataBind();
            }
            else if (ImagesForSession().Count > 0 && WordsForSession().Count > 0 && RolesForSession().Count <= 0)
            {
                repRol.Visible = false;
                repImgs.DataSource = ImagesForSession();
                repImgs.DataBind();
                repWrd.DataSource = WordsForSession();
                repWrd.DataBind();
            }
            else if (RolesForSession().Count > 0 && WordsForSession().Count > 0 && ImagesForSession().Count <= 0)
            {
                repImgs.Visible = false;
                imgBack.Visible = false;
                wordDiv.Attributes["style"] = "padding-top: 200px";
                repRol.DataSource = RolesForSession();
                repRol.DataBind();
                repWrd.DataSource = WordsForSession();
                repWrd.DataBind();
            }
            else if (ImagesForSession().Count > 0 && RolesForSession().Count <= 0 && WordsForSession().Count <= 0)
            {
                repRol.Visible = false;
                repWrd.Visible = false;
                wordDiv.Visible = false;
                roleDiv.Visible = false;
                repImgs.DataSource = ImagesForSession();
                repImgs.DataBind();
            }
            else if (ImagesForSession().Count <= 0 && WordsForSession().Count > 0 && RolesForSession().Count <= 0)
            {
                repImgs.Visible = false;
                repRol.Visible = false;
                imgBack.Visible = false;
                wordDiv.Visible = false;
                wordDiv.Attributes["style"] = "padding-top: 200px";
                repWrd.DataSource = WordsForSession();
                repWrd.DataBind();
            }
            else if (RolesForSession().Count > 0 && WordsForSession().Count <= 0 && ImagesForSession().Count <= 0)
            {
                repImgs.Visible = false;
                repWrd.Visible = false;
                imgBack.Visible = false;
                roleDiv.Visible = false;
                roleDiv.Attributes["style"] = "padding-top: 200px";
                repRol.DataSource = RolesForSession();
                repRol.DataBind();
            }

            if (AudioForSession().Count > 0)
            {
                repAudio.DataSource = AudioForSession();
                repAudio.DataBind();
            }
            else
            {
                repAudio.Visible = false;
                audioDiv.Visible = false;
            }
        }
    }

    protected void repImgs_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            if (e.Item.ItemIndex == repImgs.Items.Count - 1)
            {
                Response.Redirect("FinishedSession.aspx");
            }
        }
    }

    public List<Image> ImagesForSession()
    {
        var sesID = 0;
        int.TryParse(Request.QueryString["id"], out sesID);

        var newestSes = newSes.GetSessionOnID(sesID);
        var imgs = imgSes.GetImageOnId(sesID).Select(x => x);
        return imgs.ToList();
    }

    public List<Role> RolesForSession()
    {
        var sesID = 0;
        int.TryParse(Request.QueryString["id"], out sesID);

        var newestSes = newSes.GetSessionOnID(sesID);
        var rols = rolSes.GetRoleOnId(sesID).Select(x => x);
        return rols.ToList();
    }

    public List<Word> WordsForSession()
    {
        var sesID = 0;
        int.TryParse(Request.QueryString["id"], out sesID);

        var newestSes = newSes.GetSessionOnID(sesID);
        var wrds = wrdSes.GetWordOnId(sesID).Select(x => x);
        return wrds.ToList();
    }

    public List<Audio> AudioForSession()
    {
        var sesID = 0;
        int.TryParse(Request.QueryString["id"], out sesID);

        var newestSes = newSes.GetSessionOnID(sesID);
        var audio = audSes.GetAudioOnId(sesID);
        return audio.ToList();
    }
}