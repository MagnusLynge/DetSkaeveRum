using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AudioPage : System.Web.UI.Page
{
    AudioForSession aus = new AudioForSession();

    protected void Page_Load(object sender, EventArgs e)
    {
        CreateList();
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (fileUploader.HasFiles)
        {
            foreach (var item in fileUploader.PostedFiles)
            {
                try
                {
                    aus.CreateAudioFile(item.FileName);
                    item.SaveAs(Server.MapPath("~/Audio/" + item.FileName));
                    lblErrorText.Text = "";
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
        }
    }
    protected void btnDeleteListItem_Click(object sender, EventArgs e)
    {
        Button thisBtn = (Button)sender;
        int deleteId = Convert.ToInt32(thisBtn.CommandArgument);
        aus.DeleteAudioFile(deleteId);
        //TODO: delete from folder also
        CreateList();
    }

    protected void CreateList()
    {
        repeaterAudio.DataSource = aus.GetAllAudioFiles();
        repeaterAudio.DataBind();
    }
}