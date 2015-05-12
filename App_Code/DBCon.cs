using System;
using System.Activities.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DBCon
{

    private static readonly DBDataContext _db = new DBDataContext();
    private static DBCon _instance;

	private DBCon()
	{
		
	}

    public static DBCon Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DBCon();
            }
            return _instance;
        }
        
    }

    public static DBDataContext GetDB()
    {
        return _db;
    }


}