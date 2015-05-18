﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Images : System.Web.UI.Page
{
    protected void Upload(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + fileName);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Images/"));
            List<ListItem> files = new List<ListItem>();
            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);
                files.Add(new ListItem(fileName, "~/Images/" + fileName));
            }
            GridView1.DataSource = files;
            GridView1.DataBind();
        }
    }
}