﻿using System;
using System.Collections.Generic;
using System.IO;
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

    public List<Image> GetImageOnId(int sesID)
    {
        return (
            from sessionImage in _db.MtoMImgs
            join image in _db.Images on sessionImage.ImgId equals image.id
            where sessionImage.SessionId == sesID
            select image
            ).ToList();
    }

    public List<Image> GetAllImages()
    {
        var query = _db.Images.OrderByDescending(i => i.id).Select(i => i);
        return query.ToList();
    }

    public void DeleteImage(int id)
    {
        var query = _db.Images.Where(i => i.id == id).Select(i => i).First();

        Image delImg = _db.Images.Where(i => i.id == id).Select(i => i).FirstOrDefault();
        _db.Images.DeleteOnSubmit(delImg);
        _db.SubmitChanges();

        File.Delete(System.Web.HttpContext.Current.Server.MapPath("~/Images/") + query.FileName);
    }
}