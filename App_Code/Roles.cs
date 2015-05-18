using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IRoles
{
    List<Roles> GetAllRoles();
    List<Roles> GetRole(string role);
    void CreateRole(string role);
    void UpdateRole(string role);
    void DeleteRole(string role);

}

public class Roles : IRoles
{
    private DBDataContext _db = DBCon.GetDB();

    public int Id;
    public string Role;

    public Roles(int id, string role)
	{
        Id = id;
        Role = role;
	}

    public void DeleteRole(string role)
    {

    }

    public void UpdateRole(string role)
    {

    }

    public void CreateRole(string role)
    {
        var query = new Role { Role1 = role };
        _db.Roles.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<Roles> GetAllRoles()
    {
        var query = _db.Roles.Select(i => i);
        return query.ToList();
    }

    public List<Roles> GetRole(string role)
    {
        var query = _db.Roles.Where(i => i.Role1 == role).Select(i => i);
        return query.ToList();
    }

}