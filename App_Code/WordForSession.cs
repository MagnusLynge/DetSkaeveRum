using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// This is a class for words
/// </summary>
public class WordForSession
{
    private DBDataContext _db = DBCon.GetDB();

    #region Counstructers

    public WordForSession()
    {
        
    }

    public WordForSession(string word)
    {
        Word = word;
    }

	public WordForSession(int id, string word)
	{
	    Id = id;
	    Word = word;
	}
    #endregion

    public void DeleteWord(string word)
    {
        Word delWrd = _db.Words.Where(i => i.Word1 == word).Select(i => i).FirstOrDefault();
        if (delWrd != null)
        {
            _db.Words.DeleteOnSubmit(delWrd);
            _db.SubmitChanges();
        }
    }

    public void UpdateWord(string word)
    {
        Word updWrd = _db.Words.Where(i => i.Word1 == word).Select(i => i).Single();
        updWrd.Word1 = word;
        _db.SubmitChanges();
    }

    public void CreateWord(string word)
    {
        var query = new Word { Word1 = word};
        _db.Words.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<Word> GetAllWords()
    {
        var query = _db.Words.OrderBy(i => i.Word1).Select(i => i);
        return query.ToList();
    }

    public List<Word> GetWord(string word)
    {
        var query = _db.Words.Where(i => i.Word1 == word).OrderBy(i => i.Word1).Select(i => i);
        return query.ToList();
    }

    #region propeties
    public int Id { get; set; }
    public string Word { get; set; }
    #endregion

}