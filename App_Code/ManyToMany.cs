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

    public List<MtoMImg> GetImagesOnSession(int sesID)
    {
        var query = _db.MtoMImgs.Where(i => i.SessionId == sesID).Select(i => i);
        return query.ToList();
    }

    public void AddWordsToSession(int sesID, int wrdID)
    {
        MtoMWord newMtoM = new MtoMWord { SessionId = sesID, WordId = wrdID };
        _db.MtoMWords.InsertOnSubmit(newMtoM);
        _db.SubmitChanges();
    }

    public List<MtoMWord> GetWordsOnSession()
    {
        return null;
    }

    public void AddRolesToSession(int sesID, int rolID)
    {
        MtoMRole newMtoM = new MtoMRole { SessionId = sesID, RoleId = rolID };
        _db.MtoMRoles.InsertOnSubmit(newMtoM);
        _db.SubmitChanges();
    }

    public List<MtoMRole> GetRolesOnSession()
    {
        return null;
    }

}