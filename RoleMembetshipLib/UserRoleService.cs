using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SKFunctionCalling;

public class UserRole
{
    public string Username { get; set; }
    public string Rolename { get; set; }
}

public class UserRoleService : IFunctionCalled
{
    public event EventHandler<FunctionCallEventArgs> FunctionCalled;

    [KernelFunction]
    public List<UserRole> ListUserRoles()
    {
        WriteLine($"Function: {nameof(ListUserRoles)}");
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(ListUserRoles)));

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                SELECT Username, Rolename FROM UserRoles
            ";
        using var reader = command.ExecuteReader();
        var userRoles = new List<UserRole>();
        while (reader.Read())
        {
            userRoles.Add(new UserRole
            {
                Username = reader.GetString(0),
                Rolename = reader.GetString(1)
            });
        }
        return userRoles;
    }

    [KernelFunction]
    public List<User> GetUsersInRole(string roleName)
    {
        WriteLine($"Function: {nameof(GetUsersInRole)}");
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(GetUsersInRole)));

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                        SELECT u.* FROM Users u
                        JOIN UserRoles ur ON u.Username = ur.Username
                        JOIN Roles r ON r.Rolename = ur.Rolename
                        WHERE r.Rolename = @RoleName
                    ";
        command.Parameters.Add(DbHelper.CreateParam(command, "@RoleName", roleName));
        using var reader = command.ExecuteReader();
        var users = new List<User>();
        while (reader.Read())
        {
            users.Add(new User
            {
                Username = reader.GetString(0),
                Fullname = reader.GetString(1),
                Email = reader.GetString(2)
            });
        }
        return users;
    }

    [KernelFunction]
    public void AddUserToRole(string username, string roleName)
    {
        WriteLine($"Function: {nameof(AddUserToRole)}");
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(AddUserToRole)));

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                        INSERT INTO UserRoles (Username, Rolename)
                        VALUES (@Username,@Rolename)
                    ";
        command.Parameters.Add(DbHelper.CreateParam(command, "@Username", username));
        command.Parameters.Add(DbHelper.CreateParam(command, "@Rolename", roleName));
        command.ExecuteNonQuery();
    }

    [KernelFunction]
    public void RemoveUserFromRole(string username, string roleName)
    {
        WriteLine($"Function: {nameof(RemoveUserFromRole)}");
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(RemoveUserFromRole)));

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                        DELETE FROM UserRoles
                        WHERE Username = @Username
                        AND Rolename = @Rolename
                    ";
        command.Parameters.Add(DbHelper.CreateParam(command, "@Username", username));
        command.Parameters.Add(DbHelper.CreateParam(command, "@Rolename", roleName));
        command.ExecuteNonQuery();
    }


}
