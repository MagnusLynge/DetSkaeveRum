using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class RolesForSession
{
    private DBDataContext _db = DBCon.GetDB();

    public int Id;
    public string Role;

    public RolesForSession(int id, string role)
	{
        Id = id;
        Role = role;
	}

    public RolesForSession()
    {

    }

    public void DeleteRole(string role)
    {        
        var deleteObj = GetRole(role);

        if (deleteObj[0] == null) return;


        _db.Roles.DeleteOnSubmit(deleteObj[0]);
        _db.SubmitChanges();
    }

    public void UpdateRole(string role, string roleUpd)
    {
        var updateObj = GetRole(role);

        if (updateObj[0] == null) return;

        updateObj[0].Role1 = roleUpd;
        _db.SubmitChanges();
    }

    public void CreateRole(string role)
    {
        var query = new Role { Role1 = role };
        var check = _db.Roles.Where(i => i.Role1 == role).Select(i => i).ToList<Role>();

        if (role.Equals(check[0].Role1))
        {
            return;
        }
        else
        {
            _db.Roles.InsertOnSubmit(query);
            _db.SubmitChanges();
        }

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