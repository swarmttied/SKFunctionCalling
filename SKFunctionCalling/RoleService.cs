using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFunctionCalling;
public class Role
{
    public string Name { get; set; }
}
public class RoleService
{
    [KernelFunction]
    public void AddRole(string role)
    {
        Console.WriteLine($"Function called: AddRole(roleName:\"{role}\")");
        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
            INSERT INTO Roles (Rolename)
            VALUES (@RoleName)
        ";
        command.Parameters.Add(DbHelper.CreateParam(command, "@RoleName", role));
        command.ExecuteNonQuery();
    }

    [KernelFunction]
    public List<Role> ListRoles()
    {
        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT Rolename FROM Roles
        ";
        using var reader = command.ExecuteReader();
        var roles = new List<Role>();
        while (reader.Read())
        {
            roles.Add(new Role { Name = reader.GetString(0) });
        }
        return roles;
    }

}

