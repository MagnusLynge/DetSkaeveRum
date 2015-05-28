using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

public class AudioForSession
{
    private DBDataContext _db = DBCon.GetDB();

	public AudioForSession()
	{
	}

    public void DeleteAudioFile(string name)
    {
        var deleteObj = GetAudioFile(name);

        if (deleteObj.Count == 0)
            return;
        _db.Audios.DeleteOnSubmit(deleteObj[0]);
        _db.SubmitChanges();
    }

    public void DeleteAudioFile(int itemId)
    {
        var query = _db.Audios.Where(x => x.id == itemId).Select(x => x).First();

        Audio delAudio = _db.Audios.Where(x => x.id == itemId).Select(x => x).FirstOrDefault();

        _db.Audios.DeleteOnSubmit(delAudio);

        _db.SubmitChanges();



        File.Delete(System.Web.HttpContext.Current.Server.MapPath("~/Audio/") + query.AudioName);
    }

    public void CreateAudioFile(string name)
    {
        var query = new Audio { AudioName = name };
        var check = GetAudioFile(name);

        if (check != null && name.Equals(check[0].AudioName))
            return;

        _db.Audios.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<Audio> GetAudioFile(string name)
    {
        var query = _db.Audios.Where(x => x.AudioName == name).Select(x => x);
        var tempList = query.ToList();

        if (tempList.Count == 0)
        {
            return null;
        }
        return tempList;
    }

    public List<Audio> GetAllAudioFiles()
    {
        var query = _db.Audios.OrderBy(x => x.AudioName).Select(x => x);
        return query.ToList();
    }
}