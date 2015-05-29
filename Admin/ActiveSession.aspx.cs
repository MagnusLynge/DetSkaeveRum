using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

public partial class ActiveSession : System.Web.UI.Page
{
    CreateSes newSes = new CreateSes();
    ImagesForSession imgSes = new ImagesForSession();
    WordForSession wrdSes = new WordForSession();
    RolesForSession rolSes = new RolesForSession();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            repImgs.DataSource = ImagesForSession();
            repImgs.DataBind();

            repWrd.DataSource = WordsForSession();
            repWrd.DataBind();

            repRol.DataSource = RolesForSession();
            repRol.DataBind();
        }
    }

    public List<Image> ImagesForSession()
    {
        var userID = User.Identity.GetUserId();
        var newestSes = newSes.GetNewestSession(userID);
        var imgs = imgSes.GetImageOnId(newestSes).Select(x => x);
        return imgs.ToList();
    }

    public List<Word> WordsForSession()
    {
        var userID = User.Identity.GetUserId();
        var newestSes = newSes.GetNewestSession(userID);
        var words = wrdSes.GetWordOnId(newestSes);
        return words.ToList();
    }

    public List<Role> RolesForSession()
    {
        var userID = User.Identity.GetUserId();
        var newestSes = newSes.GetNewestSession(userID);
        var roles = rolSes.GetRoleOnId(newestSes);
        return roles.ToList();
    }

}