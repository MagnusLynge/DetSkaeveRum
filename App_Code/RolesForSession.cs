using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class RolesForSession
{
    private DBDataContext _db = DBCon.GetDB();

    public RolesForSession()
    {

    }

    public void DeleteRole(string role)
    {
        var deleteObj = GetRole(role);

        if (deleteObj == null) return;
        
        _db.Roles.DeleteOnSubmit(deleteObj[0]);
        _db.SubmitChanges();

    }

    public void UpdateRole(string role, string roleUpd)
    {
        var updateObj = GetRole(role);

        if (updateObj != null)
        {
            updateObj[0].Role1 = roleUpd;
            _db.SubmitChanges();
        }
    }

    public void CreateRole(string role)
    {
        var query = new Role { Role1 = role };
        var check = _db.Roles.Where(i => i.Role1 == role).Select(i => i).ToList<Role>();


        if (check.Count > 0 && role.Equals(check[0].Role1))
        {
            return;
        }
        _db.Roles.InsertOnSubmit(query);
        _db.SubmitChanges();
    }

    public List<Role> GetRoleOnId(int sesID)
    {
        return (from sessionRole in _db.MtoMRoles
            join role in _db.Roles on sessionRole.RoleId equals role.id
            where sessionRole.SessionId == sesID
            select role).ToList();
    }

    public List<Role> GetAllRoles()
    {
        var query = _db.Roles.OrderBy(i => i.Role1).Select(i => i);
        return query.ToList();
    }

    public int GetRoleId(string rol)
    {
        var query = _db.Roles.Where(i => i.Role1 == rol).Select(i => i).First();
        return query.id;
    }

    public List<Role> GetRole(string role)
    {
        var query = _db.Roles.Where(i => i.Role1 == role).Select(i => i);

        if (query.ToList().Count == 0)
        {
            return null;
        }

        return query.ToList();
    }

    public List<Role> GetRole(int id)
    {
        var query = _db.Roles.Where(i => i.id == id).Select(i => i);
        return query.ToList();
    }

    public int CountAllRoles()
    {
        var query = _db.Roles.Select(i => i);
        var result = query.Count();

        return result;
    }

    public bool CheckIfRoleExists(string role)
    {
        var check = _db.Roles.Where(i => i.Role1 == role).Select(i => i).Count();

        if (check <= 0)
        {
            return false;
        }

        return true;
    }

}