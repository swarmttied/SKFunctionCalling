using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFunctionCalling;

public class User
{
    public string Username { get; set; }
    public string Fullname { get; set; }
    public string Email { get; set; }
}

public class UserService
{
    [KernelFunction]
    public List<User> ListUsers()
    {
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
    public void AddUser(User newUser)
    {
        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                INSERT INTO Users (Username, Fullname, Email)
                VALUES (@Username, @Fullname, @Email)
            ";
        command.Parameters.Add(DbHelper.CreateParam(command, "@Username", newUser.Username));
        command.Parameters.Add(DbHelper.CreateParam(command, "@Fullname", newUser.Fullname));
        command.Parameters.Add(DbHelper.CreateParam(command, "@Email", newUser.Email));
        command.ExecuteNonQuery();
    }

    [KernelFunction]
    public User GetUserByUsername(string username)
    {
        using var connection = DbHelper.GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Users WHERE Username = @Username";
        command.Parameters.Add(DbHelper.CreateParam(command, "@Username", username));
        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            return new User
            {
                Username = reader.GetString(9),
                Fullname = reader.GetString(1),
                Email = reader.GetString(2)
            };
        }
        return null;
    }
}
