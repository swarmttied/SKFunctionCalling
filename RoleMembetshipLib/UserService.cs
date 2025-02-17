using Microsoft.SemanticKernel;
using SKLIb;
using System.ComponentModel;
using static System.Console;

namespace SKFunctionCalling;

public class User
{
    public required string Username { get; set; }
    public required string Fullname { get; set; }
    public required string Email { get; set; }

    override public string ToString()
    {
        return $"{Username} - {Fullname} - {Email}";
    }
}

public class UserService : IFunctionCalled
{
    public event EventHandler<FunctionCallEventArgs>? FunctionCalled;

    [KernelFunction]
    public List<User> ListUsers()
    {
        WriteLine($"Function: {nameof(ListUsers)} ");
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(ListUsers)));

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
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(AddUser)));

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
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(RemoveUser)));

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
        FunctionCalled?.Invoke(this, new FunctionCallEventArgs(nameof(GetUser)));

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
