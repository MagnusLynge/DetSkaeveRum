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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            repImgs.DataSource = ImagesForSession();
            repImgs.DataBind();
        }
    }

    public List<Image> ImagesForSession()
    {
        var userID = User.Identity.GetUserId();
        var newestSes = newSes.GetNewestSession(userID);


        //var imgs = mtm.GetImagesOnSession(newestSes).Select(i => imgSes.GetImageOnId(i.ImgId).ToList()).Select(i => i);

        //var imgsOnSes = mtm.GetImagesOnSession(newestSes).Select(i => i.ImgId);

        var imgs = imgSes.GetImageOnId(newestSes).Select(x => x);

        return imgs.ToList();
    }
}