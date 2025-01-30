using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SKFunctionCalling;

public class User
{
    public string Username { get; set; }
    public string Fullname { get; set; }
    public string Email { get; set; }

    override public string ToString()
    {
        return $"{Username} - {Fullname} - {Email}";
    }
}

public class UserService
{
    [KernelFunction]
    public List<User> ListUsers()
    {
        WriteLine("Function: ListUsers");

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                SELECT * FROM Users
            ";
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
    public void AddUser([Description("The user to add. Please validate email format")] User user)
    {
        WriteLine($"Function: AddUser");

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                INSERT INTO Users (Username, Fullname, Email)
                VALUES (@Username, @Fullname, @Email)
            ";
        command.Parameters.Add(DbHelper.CreateParam(command, "@Username", user.Username));
        command.Parameters.Add(DbHelper.CreateParam(command, "@Fullname", user.Fullname));
        command.Parameters.Add(DbHelper.CreateParam(command, "@Email", user.Email));
        command.ExecuteNonQuery();
    }

    [KernelFunction]
    public void RemoveUser(string username)
    {
        WriteLine($"Function: RemoveUser");

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Users WHERE Username = @Username";
        command.Parameters.Add(DbHelper.CreateParam(command, "@Username", username));
        command.ExecuteNonQuery();
    }


    [KernelFunction]
    [Description("Checks if the user is in the system")]
    public User GetUser(string username)
    {
        WriteLine($"Function: GetUser");

        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Users WHERE Username = @Username";
        command.Parameters.Add(DbHelper.CreateParam(command, "@Username", username));
        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            return new User
            {
                Username = reader.GetString(0),
                Fullname = reader.GetString(1),
                Email = reader.GetString(2)
            };
        }

        return null;
    }
}
