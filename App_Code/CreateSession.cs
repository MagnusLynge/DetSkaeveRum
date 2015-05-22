using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// CreateSession is for createing a session
/// </summary>
public class CreateSession
{
    private DBDataContext _db = DBCon.GetDB();

    #region Constructor
    public CreateSession()
    {
        
    }
    public CreateSession(int teacherID, bool active)
	{
	    TeacherID = teacherID;
	    Active = active;
	}
    #endregion

    public List<Session> AllActiveSessions()
    {
        var query = _db.Sessions.Where(i => i.Active == true).Select(i => i);
        return query.ToList();
    }

    public List<Session> AllSessions()
    {
        var query = _db.Sessions.OrderByDescending(i => i.id).Select(i => i);
        return query.ToList();
    }

    public List<Session> GetSessionOnTeacherId(int id)
    {
        var query = _db.Sessions.Where(i => i.TeacherId == id).Select(i => i);
        return query.ToList();
    }

    public void CreateNewSession(int teacherId, bool active)
    {
        var query = new Session {TeacherId = teacherId, Active = active};

        _db.Sessions.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public void DeleteSession(int sesId)
    {
        Session delSes = _db.Sessions.Where(i => i.id == sesId).Select(i => i).FirstOrDefault();
        if (delSes == null) return;
        
        _db.Sessions.DeleteOnSubmit(delSes);
        _db.SubmitChanges();

    }

    public void UpdateSession(int sesId, bool acti)
    {
        Session updSes = _db.Sessions.Where(i => i.id == sesId).Select(i => i).Single();
        if (updSes == null) return;

        updSes.Active = acti;
        _db.SubmitChanges();

    }

    #region Propeties
    public int Id { get; set; }
    public int TeacherID { get; set; }
    public bool Active { get; set; }
    #endregion

}