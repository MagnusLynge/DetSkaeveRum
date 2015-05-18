using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IWords
{
    List<WordForSession> GetAllWords();
    List<WordForSession> GetWord(string word);
    void CreateWord(string word);
    void UpdateWord(string word);
    void DeleteWord(string word);

}


/// <summary>
/// This is a class for words
/// </summary>
public partial class WordForSession : IWords
{
    private DBDataContext _db = DBCon.GetDB();

    #region Counstructers
   
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
        
    }

    public void UpdateWord(string word)
    {
        
    }

    public void CreateWord(string word)
    {
        var query = new WordForSession { Word = word};
        _db.Wordss.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<WordForSession> GetAllWords()
    {
        var query = _db.Wordss.Select(i => i);
        return query.ToList();
    }

    public List<WordForSession> GetWord(string word)
    {
        var query = _db.Wordss.Where(i => i.Word == word).Select(i => i).ToList();
        return query.ToList();
    }




    public int Id { get; set; }
    public string Word { get; set; }

}