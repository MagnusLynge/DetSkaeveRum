using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ImagesForSession
/// </summary>
public class ImagesForSession
{
    private DBDataContext _db = DBCon.GetDB();
	public ImagesForSession()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void AddImage(string fileName) 
    {
        var query = new Image { FileName = fileName };
        _db.Images.InsertOnSubmit(query);
        _db.SubmitChanges();
    }
}