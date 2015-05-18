using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Roles
{
    private DBDataContext _db = DBCon.GetDB();

    public int Id;
    public string Role;

    public Roles(int id, string role)
	{
        Id = id;
        Role = role;
	}

    public Roles()
    {

    }

    public void DeleteRole(int id)
    {
        var deleteObj = GetRole(id);
        _db.Roles.DeleteOnSubmit(deleteObj[0]);
        _db.SubmitChanges();
    }

    public void UpdateRole(int id, string role)
    {
        var updateObj = GetRole(id);
        updateObj[0].Role1 = role;
        _db.SubmitChanges();
    }

    public void CreateRole(string role)
    {
        var query = new Role { Role1 = role };
        _db.Roles.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<Role> GetAllRoles()
    {
        var query = _db.Roles.Select(i => i);
        return query.ToList();
    }

    public List<Role> GetRole(string role)
    {
        var query = _db.Roles.Where(i => i.Role1 == role).Select(i => i);
        return query.ToList();
    }

    public List<Role> GetRole(int id)
    {
        var query = _db.Roles.Where(i => i.id == id).Select(i => i);
        return query.ToList();
    }

}