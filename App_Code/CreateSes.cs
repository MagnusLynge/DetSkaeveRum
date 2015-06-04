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
        bool check = checkNumberOfSes(teacherId);
        if (check == true)
        {
            int sesForDel = oldestSes(teacherId);
            DeleteSession(sesForDel);
        }

        var query = new Session { TeacherId = teacherId, Active = active, SesName = sesName };

        _db.Sessions.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public void DeleteSession(int sesId)
    {
        //List<MtoMImg> imgList = _db.MtoMImgs.Where(i => i.SessionId == sesId).Select(i => i);
        //_db.MtoMImgs.DeleteAllOnSubmit(imgList);
        //List wordList = GetMtoMWord
        if(checkMtoMAudio(sesId) == true)
        {
            List<MtoMAudio> list = GetMtoMAudio(sesId);
            _db.MtoMAudios.DeleteAllOnSubmit(list);
        }
        if (checkMtoMImg(sesId) == true)
        {
            List<MtoMImg> list = GetMtoMImg(sesId);
            _db.MtoMImgs.DeleteAllOnSubmit(list);
        }
        if (checkMtoMRole(sesId) == true)
        {
            List<MtoMRole> list = GetMtoMRole(sesId);
            _db.MtoMRoles.DeleteAllOnSubmit(list);
        }
        if (checkMtoMWord(sesId) == true)
        {
            List<MtoMWord> list = GetMtoMWord(sesId);
            _db.MtoMWords.DeleteAllOnSubmit(list);
        }


        Session delSes = _db.Sessions.Where(i => i.id == sesId).Select(i => i).FirstOrDefault();
        //if (delSes == null) return;

        _db.Sessions.DeleteOnSubmit(delSes);
        _db.SubmitChanges();

    }

    public bool checkMtoMWord(int sesId)
    {
        if (_db.MtoMWords.Any(i => i.SessionId == sesId))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool checkMtoMImg(int sesId)
    {
        if (_db.MtoMImgs.Any(i => i.SessionId == sesId))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool checkMtoMRole(int sesId)
    {
        if (_db.MtoMRoles.Any(i => i.SessionId == sesId))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool checkMtoMAudio(int sesId)
    {
        if (_db.MtoMAudios.Any(i => i.SessionId == sesId))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public List<MtoMImg> GetMtoMImg(int sesId)
    {
        var query = _db.MtoMImgs.Where(i => i.SessionId == sesId).Select(i => i);
        return query.ToList();
    }
    public List<MtoMRole> GetMtoMRole(int sesId)
    {
        var query = _db.MtoMRoles.Where(i => i.SessionId == sesId).Select(i => i);
        return query.ToList();
    }
    public List<MtoMWord> GetMtoMWord(int sesId)
    {
        var query = _db.MtoMWords.Where(i => i.SessionId == sesId).Select(i => i);
        return query.ToList();
    }
    public List<MtoMAudio> GetMtoMAudio(int sesId)
    {
        var query = _db.MtoMAudios.Where(i => i.SessionId == sesId).Select(i => i);
        return query.ToList();
    }

    public void UpdateSession(int sesId, bool acti)
    {
        Session updSes = _db.Sessions.Where(i => i.id == sesId).Select(i => i).Single();
        if (updSes == null) return;

        updSes.Active = acti;
        _db.SubmitChanges();

    }

    public bool checkNumberOfSes(string teachId)
    {
        int numberOf = _db.Sessions.Where(i => i.TeacherId == teachId).Select(i => i).Count();
        if (numberOf >= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int oldestSes(string teachId)
    {
        var query = _db.Sessions.Where(i => i.TeacherId == teachId).Select(i => i.id).Min();
        return query;
    }

    #region Propeties
    public int Id { get; set; }
    public int TeacherID { get; set; }
    public bool Active { get; set; }
    public string SessionName { get; set; }
    #endregion

}