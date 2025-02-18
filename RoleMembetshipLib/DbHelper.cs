using Microsoft.Data.Sqlite;
using System.Data;


namespace SKFunctionCalling;
public static class DbHelper
{
    public static void CreateDbIfNotExist()
    {
        using var connection = GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Roles (                   
                    Rolename TEXT NOT NULL PRIMARY KEY
                );
                CREATE TABLE IF NOT EXISTS Users (                    
                    Username TEXT NOT NULL PRIMARY KEY,
                    Fullname TEXT NOT NULL,
                    Email TEXT NOT NULL
                );
                CREATE TABLE IF NOT EXISTS UserRoles (
                    Username TEXT NOT NULL,
                    Rolename TEXT NOT NULL,
                    PRIMARY KEY(Username, Rolename),
                    FOREIGN KEY(Username) REFERENCES Users(Username),
                    FOREIGN KEY(Rolename) REFERENCES Roles(Rolename)
                );
            ";
        command.ExecuteNonQuery();
    }

    public static void TruncateTables()
    {
        using var connection = GetDbConnection();
        var command = connection.CreateCommand();
        command.CommandText = @"
                DELETE FROM UserRoles;
                DELETE FROM Roles;
                DELETE FROM Users;             
            ";
        command.ExecuteNonQuery();
    }

    public static IDbConnection GetDbConnection()
    {
        var connection = new SqliteConnection(GetDbConStr());
        connection.Open();
        return connection;
    }

    public static string GetDbConStr()
    {
        var dbPath = Path.Combine(AppContext.BaseDirectory, "RoleMembership.db");
        return $"Data Source={dbPath}";
    }

    public static IDbDataParameter CreateParam(IDbCommand dbCommand, string name, object value)
    {
        var param = dbCommand.CreateParameter();
        param.ParameterName = name;
        param.Value = value;
        return param;
    }


}
