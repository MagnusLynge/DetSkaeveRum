using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IWords
{
    List<Word> GetAllWords();
    List<Word> GetWord(string word);
    void CreateWord(string word);
    void UpdateWord(string word);
    void DeleteWord(string word);

}


/// <summary>
/// This is a class for words
/// </summary>
public class Words : IWords
{
    private DBDataContext _db = DBCon.GetDB();

    public Words()
    {
        
    }

	public Words(int id, string word)
	{
	    Id = id;
	    Word = word;
	}

    public void DeleteWord(string word)
    {
        
    }

    public void UpdateWord(string word)
    {
        
    }

    public void CreateWord(string word)
    {
        var query = new Word { Word1 = word};
        _db.Words.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<Word> GetAllWords()
    {
        var query = _db.Words.Select(i => i);
        return query.ToList();
    }

    public List<Word> GetWord(string word)
    {
        var query = _db.Words.Where(i => i.Word1 == word).Select(i => i);
        return query.ToList();
    }




    public int Id { get; set; }
    public string Word { get; set; }

}