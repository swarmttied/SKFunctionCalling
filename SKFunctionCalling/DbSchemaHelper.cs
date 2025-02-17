using System;
using System.Data;
using System.Text;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace SKFunctionCalling;

public static class DbSchemaHelper
{
    public static string PrintDatabaseSchema(string connectionString)
    {
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"
                SELECT TABLE_NAME 
                FROM INFORMATION_SCHEMA.TABLES 
                WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'SK';
            ";

        using var reader = command.ExecuteReader();
        List<string> tables = new();
        while (reader.Read())
        {
            string tableName = reader.GetString(0);
            //Console.WriteLine($"Table: {tableName}");
            tables.Add(tableName);
            //PrintTableSchema(connection, tableName);
            //PrintTableConstraints(connection, tableName);
            //PrintTableIndices(connection, tableName);
        }
        reader.Close();
        reader.DisposeAsync();
        StringBuilder sb = new();
        foreach (var tbl in tables)
        {
            sb.Append($"SK.{tbl} ");
            sb.Append(PrintTableSchema(connection, tbl));
            PrintTableConstraints(connection, tbl);
        }

        string schemaStr = sb.ToString();
        return schemaStr;
    }

    private static string PrintTableSchema(SqlConnection connection, string tableName)
    {
        using var command = connection.CreateCommand();
        command.CommandText = @"
                SELECT COLUMN_NAME, DATA_TYPE 
                FROM INFORMATION_SCHEMA.COLUMNS 
                WHERE TABLE_NAME = @TableName;
            ";
        command.Parameters.AddWithValue("@TableName", tableName);
        StringBuilder sb  = new("(");
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            string columnName = reader.GetString(0);
            string columnType = reader.GetString(1);
            //sb.Append($"{columnName}:{columnType},");
            sb.Append($"{columnName},");
            //Console.WriteLine($"\tColumn: {columnName}, Type: {columnType}");
        }
        string res = sb.ToString().TrimEnd(',');
        return res + ")\n";


    }

    private static void PrintTableConstraints(SqlConnection connection, string tableName)
    {
        using var command = connection.CreateCommand();
        command.CommandText = @"
                SELECT CONSTRAINT_TYPE, COLUMN_NAME
                FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS TC
                JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU
                ON TC.CONSTRAINT_NAME = KCU.CONSTRAINT_NAME
                WHERE TC.TABLE_NAME = @TableName;
            ";
        command.Parameters.AddWithValue("@TableName", tableName);

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            string constraintType = reader.GetString(0);
            string columnName = reader.GetString(1);
            //Console.WriteLine($"\tConstraint: {constraintType}, Column: {columnName}");
        }
    }

    private static void PrintTableIndices(SqlConnection connection, string tableName)
    {
        using var command = connection.CreateCommand();
        command.CommandText = @"
                SELECT i.name AS IndexName, c.name AS ColumnName
                FROM sys.indexes i
                INNER JOIN sys.index_columns ic ON i.index_id = ic.index_id AND i.object_id = ic.object_id
                INNER JOIN sys.columns c ON ic.column_id = c.column_id AND ic.object_id = c.object_id
                WHERE i.object_id = OBJECT_ID(@TableName);
            ";
        command.Parameters.AddWithValue("@TableName", tableName);

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            string indexName = reader.GetString(0);
            string columnName = reader.GetString(1);
           // Console.WriteLine($"\tIndex: {indexName}, Column: {columnName}");
        }
    }

    public static DataTable RunQuery(string connectionString, string query)
    {
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = query;

        using var adapter = new SqlDataAdapter(command);
        var dataTable = new DataTable();
        adapter.Fill(dataTable);

        return dataTable;
    }

}
