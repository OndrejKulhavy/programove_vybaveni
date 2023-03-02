using Microsoft.Data.SqlClient;
using Spectre.Console;
using System.Configuration;
using System.Diagnostics;

class Database
{
    SqlConnection connection;
    public SqlConnection Connection { get => connection; set => connection = value; }
    public Database()
    {
        connect();
    }
    public void connect()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Connecting to database[/]");
        AnsiConsole.MarkupLine("[grey]Reading connection string from App.config...[/]");

        var connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        if (connectionString == null || connectionString == "")
        {
            AnsiConsole.MarkupLine("[red]Connection string not found in App.config [/]");
            AnsiConsole.MarkupLine("[grey]Press any key to open App.config...[/]");
            Console.ReadKey();
            Process.Start("notepad.exe", "App.config");
            AnsiConsole.MarkupLine("[grey]Press any key to reload...[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine("[grey]Reloading...[/]");
            Process.Start("dotnet.exe", "run");
            Environment.Exit(0);
        }
        else
        {
            AnsiConsole.MarkupLine("[green]Connection string found in App.config[/]: " + connectionString);
            connection = new SqlConnection(connectionString);
            connection.Open();
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        }
    }
    public void close()
    {
        connection.Close();
    }
}

