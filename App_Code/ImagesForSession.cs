using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

    public void DeleteImage(int id)
    {
        Image delImg = _db.Images.Where(i => i.id == id).Select(i => i).FirstOrDefault();
        if (delImg == null) return;
        _db.Images.DeleteOnSubmit(delImg);
        _db.SubmitChanges();
    }

    public void AddImage(string fileName) 
    {
        var query = new Image { FileName = fileName };
        _db.Images.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public int GetImageId(string fileName)
    {
        var query = _db.Images.Where(i => i.FileName == fileName).Select(i => i).First();

        if (query.id == null) {
            return 0;
        }

        return query.id;
    }

    public List<Image> GetAllImages()
    {
        var query = _db.Images.OrderBy(i => i.id).Select(i => i);
        return query.ToList();
    }
}