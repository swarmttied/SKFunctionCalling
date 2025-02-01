using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SKFunctionCalling;
public class Role
{
    public string Name { get; set; }
}
public class RoleService : IFunctionCalled
{
    public event EventHandler<FunctionCallEventArgs> FunctionCalled;
    public static void AddRole(string role)
    {
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
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(ListRoles)));
        WriteLine($"Function: {nameof(ListRoles)}");

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

