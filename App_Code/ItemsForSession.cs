using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ItemsForSession
/// </summary>
public class ItemsForSession
{
    private DBDataContext _db = DBCon.GetDB();

	public ItemsForSession()
	{
		
	}

    #region Images
    public void ChooseImgsForSession(int sesId, int imgId)
    {
        var query = new MtoMImg { SessionId = sesId, ImgId = imgId };

        _db.MtoMImgs.InsertOnSubmit(query);
        _db.SubmitChanges();

    }
    
    public List<MtoMImg> ImagesOnSessionId(int sesId)
    {
        var query = _db.MtoMImgs.Where(i => i.SessionId == sesId).Select(i => i);
        return query.ToList();
    }

    public void DeleteImagesOnSessionId(int sesId)
    {
        var query = _db.MtoMImgs.Where(i => i.SessionId == sesId).Select(i => i).FirstOrDefault();

        _db.MtoMImgs.DeleteOnSubmit(query);
        _db.SubmitChanges();
    }
    #endregion

    #region Words
    public void ChooseWordsForSession(int sesId, int wrdId)
    {
        var query = new MtoMWord {SessionId = sesId, WordId = wrdId};
        
        _db.MtoMWords.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<MtoMWord> WordsOnSessionId(int sesId)
    {
        var query = _db.MtoMWords.Where(i => i.SessionId == sesId).Select(i => i);
        return query.ToList();
    }

    public void DeleteWordsOnSessionId(int sesId)
    {
        var query = _db.MtoMWords.Where(i => i.SessionId == sesId).Select(i => i).FirstOrDefault();

        _db.MtoMWords.DeleteOnSubmit(query);
        _db.SubmitChanges();
    }
    #endregion

    #region Roles
    public void ChooseRolesForSession(int sesId, int rolId)
    {
        var query = new MtoMRole {SessionId = sesId, RoleId = rolId};

        _db.MtoMRoles.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<MtoMRole> RolesOnSessionId(int sesId)
    {
        var query = _db.MtoMRoles.Where(i => i.SessionId == sesId).Select(i => i);
        return query.ToList();
    }

    public void DeleteRolesOnSessionId(int sesId)
    {
        var query = _db.MtoMRoles.Where(i => i.SessionId == sesId).Select(i => i).FirstOrDefault();

        _db.MtoMRoles.DeleteOnSubmit(query);
        _db.SubmitChanges();
    }
    #endregion

}