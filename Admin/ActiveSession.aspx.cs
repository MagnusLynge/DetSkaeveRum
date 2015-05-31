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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            repImgs.DataSource = ImagesForSession();
            repImgs.DataBind();

            repRol.DataSource = RolesForSession();
            repRol.DataBind();

            repWrd.DataSource = WordsForSession();
            repWrd.DataBind();
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

}