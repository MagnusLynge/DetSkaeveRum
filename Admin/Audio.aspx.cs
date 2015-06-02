using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Audio : System.Web.UI.Page
{
    AudioForSession aus = new AudioForSession();

    protected void Page_Load(object sender, EventArgs e)
    {
        CreateList();
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        try
        {
            lblErrorText.Text = "";
            string namesForErrorMessage = "";

            if (fileUploader.HasFiles)
            {
                foreach (var item in fileUploader.PostedFiles)
                {
                    if (!item.FileName.EndsWith(".mp3", System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        namesForErrorMessage += "'" + item.FileName + "', ";
                        lblErrorText.Text = namesForErrorMessage + "could not be uploadet. The only supported extensions are .mp3";
                    }
                    else
                    {
                        aus.CreateAudioFile(item.FileName);
                        item.SaveAs(Server.MapPath("~/Audio/" + item.FileName));
                    }
                }
            }
            CreateList();
        }
        catch (System.Data.SqlTypes.SqlTruncateException)
        {
            lblErrorText.Text = "Filename Too Long";
        }
        catch (System.IO.PathTooLongException)
        {
            lblErrorText.Text = "Filename Too Long";
        }
    }


    protected void btnDeleteListItem_Click(object sender, EventArgs e)
    {
        LinkButton thisBtn = (LinkButton)sender;
        int deleteId = Convert.ToInt32(thisBtn.CommandArgument);
        aus.DeleteAudioFile(deleteId);
        Response.Redirect(Request.RawUrl);
    }

    protected void CreateList()
    {
        repeaterAudio.DataSource = aus.GetAllAudioFiles();
        repeaterAudio.DataBind();
    }
}