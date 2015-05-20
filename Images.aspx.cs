﻿using System;
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
        //if (!IsPostBack)
        //{

        //    string[] filePaths = Directory.GetFiles(Server.MapPath("~/Images/"));
        //    List<ListItem> files = new List<ListItem>();
        //    foreach (string filePath in filePaths)
        //    {
        //        string fileName = Path.GetFileName(filePath);
        //        String imageid = Convert.ToString(imgSession.GetImageId(fileName));
        //        files.Add(new ListItem(imageid, "~/Images/" + fileName));

        //    }
        //    GridView1.DataSource = files;
        //    GridView1.DataBind();
        //    GridView1.Columns[0].Visible = false;
        //}

        RepeaterIMG.DataSource = imgSession.GetAllImages();
        RepeaterIMG.DataBind();
    }

    /*
    protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string item = e.Row.Cells[0].Text;
            foreach (Button button in e.Row.Cells[2].Controls.OfType<Button>())
            {
                if (button.CommandName == "Delete")
                {
                    button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                }
            }
        }
    }
    */

    protected void OnRowDataBound(object sender, GridViewDeleteEventArgs e)
    {
        int index = Convert.ToInt32(e.RowIndex);
        DataTable dt = ViewState["dt"] as DataTable;
        dt.Rows[index].Delete();
        ViewState["dt"] = dt;
    }

    protected void OnRowDataBound2(object sender, GridViewDeleteEventArgs e)
    {
        /*
        int index = Convert.ToInt32(e.RowIndex);
        DataTable dt = ViewState["dt"] as DataTable;
        dt.Rows[index].Delete();
        ViewState["dt"] = dt;
        */

        int index = Convert.ToInt32(e.RowIndex);

        string[] filePaths = Directory.GetFiles(Server.MapPath("~/Images/"));
        List<ListItem> files = new List<ListItem>();

        foreach (string filePath in filePaths)
        {
            string fileName = Path.GetFileName(filePath);
            int imageid = imgSession.GetImageId(fileName);
        }


        DataTable dt = ViewState["dt"] as DataTable;

    }
}