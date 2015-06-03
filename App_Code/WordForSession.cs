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


    public void UpdateWord(string word)
    {
        Word updWrd = _db.Words.Where(i => i.Word1 == word).Select(i => i).Single();
        if (updWrd == null) return;
        updWrd.Word1 = word;
        _db.SubmitChanges();
    }

    public List<Word> GetWordOnId(int sesID)
    {
        return (from sessionWord in _db.MtoMWords
                join word in _db.Words on sessionWord.WordId equals word.id
                where sessionWord.SessionId == sesID
                select word).ToList();
    }

    public bool CheckIfWordExists(string word)
    {
        var check = _db.Words.Where(i => i.Word1 == word).Select(i => i).Count();

        if (check <= 0)
        {
            return false;
        }

        return true;
    }

    public void CreateWord(string word)
    {
        var query = new Word { Word1 = word};

        var check = _db.Words.Where(i => i.Word1 == word).Select(i => i).Count();

        if (check > 0 )
        {
            return;
        }
        
            _db.Words.InsertOnSubmit(query);
            _db.SubmitChanges(); 
           
    }

    public int CountAllWords()
    {
        var query = _db.Words.Select(i => i);
        var result = query.Count();

        return result;
    }

    public int GetWordId(string wrd)
    {
        var query = _db.Words.Where(i => i.Word1 == wrd).Select(i => i).First();
        return query.id;
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

    public void DeleteWord(string word)
    {
        int wordId = GetWordId(word);
        if (checkMtm(wordId) == true) ;
        {
            List<MtoMWord> list = GetMtoMSpecific(wordId);
            _db.MtoMWords.DeleteAllOnSubmit(list);
        }

        Word delWrd = _db.Words.Where(i => i.Word1 == word).Select(i => i).FirstOrDefault();
        if (delWrd == null) return;
        _db.Words.DeleteOnSubmit(delWrd);
        _db.SubmitChanges();
    }

    public List<MtoMWord> GetMtoMSpecific(int wordid)
    {
        var query = _db.MtoMWords.Where(i => i.WordId == wordid).Select(i => i);
        return query.ToList();
    }

    public bool checkMtm(int wordId)
    {
        if (_db.MtoMWords.Any(i => i.WordId == wordId))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    #region propeties
    public int Id { get; set; }
    public string Word { get; set; }
    #endregion

}