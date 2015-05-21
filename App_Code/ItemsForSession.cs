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




}