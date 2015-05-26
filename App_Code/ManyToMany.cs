using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ManyToMany
/// </summary>
public class ManyToMany
{
    private DBDataContext _db = DBCon.GetDB();

    public ManyToMany()
    {

    }

    public void AddImagesToSession(int sesID, int imgID)
    {
        MtoMImg newMtoM = new MtoMImg { SessionId = sesID, ImgId = imgID };
        _db.MtoMImgs.InsertOnSubmit(newMtoM);
        _db.SubmitChanges();
    }

    public List<MtoMImg> GetImagesOnSession()
    {
        return null;
    }



}