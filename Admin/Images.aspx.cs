using System;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class Images : System.Web.UI.Page
    {
        ImagesForSession imgSession = new ImagesForSession();
        protected void Upload(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                foreach (var file in FileUpload1.PostedFiles)
                {
                    file.SaveAs(Server.MapPath("~/Images/") + file.FileName);
                    imgSession.AddImage(file.FileName);
                }

                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterIMG.DataSource = imgSession.GetAllImages();
            RepeaterIMG.DataBind();
        }

        protected void DeleteImage(object sender, EventArgs e)
        {
            LinkButton btnDelete = (LinkButton)(sender);
            string btnId = btnDelete.CommandArgument;
            int imgId = Convert.ToInt32(btnId);
            imgSession.DeleteImage(imgId);
            Response.Redirect(Request.RawUrl);
        }

    }
}