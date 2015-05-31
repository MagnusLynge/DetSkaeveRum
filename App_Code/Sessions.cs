using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Sessions
/// </summary>
public class Sessions
{
    private DBDataContext _db = DBCon.GetDB();

	public Sessions()
	{
	}

    public List<Session> GetAllSessionsOnTeacherID(string teaID)
    {
        var query = _db.Sessions.Where(i => i.TeacherId == teaID).Select(i => i);
        return query.ToList();
    }
    public int getSessionIDByName(string sesName)
    {
        var query = _db.Sessions.Where(i => i.SesName == sesName).Select(i => i).First();

        if (query.id == null) { return 0; }
        else { return query.id; }
    }

}