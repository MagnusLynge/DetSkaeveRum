using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

public partial class Images : System.Web.UI.Page
{
    ImagesForSession imgSession = new ImagesForSession();
    protected void Upload(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + fileName);
            imgSession.AddImage(fileName);
            Response.Redirect(Request.Url.AbsoluteUri);

        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        RepeaterIMG.DataSource = imgSession.GetAllImages();
        RepeaterIMG.DataBind();
    }

    protected void OnRowDataBound(object sender, GridViewDeleteEventArgs e)
    {
        int index = Convert.ToInt32(e.RowIndex);
        DataTable dt = ViewState["dt"] as DataTable;
        dt.Rows[index].Delete();
        ViewState["dt"] = dt;
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