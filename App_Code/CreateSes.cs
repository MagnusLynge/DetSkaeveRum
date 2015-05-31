using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// CreateNewSession is for createing a session
/// </summary>
public class CreateSes
{
    private DBDataContext _db = DBCon.GetDB();

    #region Constructor
    public CreateSes()
    {
        
    }
    public CreateSes(int teacherID, bool active)
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

    public List<Session> GetSessionOnTeacherId(string id)
    {
        var query = _db.Sessions.Where(i => i.TeacherId == id).Select(i => i);
        return query.ToList();
    }

    public int GetNewestSession(string id)
    {
        var query = _db.Sessions.Where(i => i.TeacherId == id).Select(i => i.id).Max();
        return query;
    }

    public List<Session> GetSessionOnID(int ID)
    {
        var query = _db.Sessions.Where(i => i.id == ID).Select(i => i);
        return query.ToList();
    }

    public void CreateNewSession(string teacherId, bool active, string sesName)
    {
        var query = new Session {TeacherId = teacherId, Active = active, SesName = sesName};

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
    public string SessionName { get; set; }
    #endregion

}