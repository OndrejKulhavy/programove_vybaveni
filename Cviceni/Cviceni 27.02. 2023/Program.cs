using Spectre.Console;
public static class Program
{
    
    public static void Main(string[] args)
    {

        User user = null;
        Welcome();
        var database = new Database();
        do
        {
            Console.Clear();
            if (user != null)
            {
                AnsiConsole.MarkupLine($"[bold green]Logged in as {user.Name}[/]");
                var optionLogged = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select an option")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                        .AddChoices(new[] { "Send message", "List messages","Logout", "Exit" }));

                switch (optionLogged)
                {
                    case "Send message":
                        SendMessage(database, user);
                        break;
                    case "Logout":
                        user = null;
                        break;
                    case "List messages":
                        ListMessages(database, user);
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                }
            }else{
                var optionMainMenu = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select an option")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                        .AddChoices(new[] { "Register", "Login", "Exit" }));

                switch (optionMainMenu)
                {
                    case "Register":
                        Register(database);
                        break;
                    case "Login":
                        user = Login(database);
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                }
            }

        } while (true);
    }

    public static void Welcome()
    {
        AnsiConsole.Write(new FigletText("Messangeros").Centered());
        AnsiConsole.MarkupLine("[bold green]Welcome to Messangeros![/]");
        AnsiConsole.MarkupLine("[bold green]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public static void Register(Database database)
    {
        AnsiConsole.MarkupLine("[bold green]Register[/]");
        var name = AnsiConsole.Ask<string>("Name: ");
        var email = AnsiConsole.Ask<string>("Email: ");
        var password = AnsiConsole.Ask<string>("Password: ");
        var user = new User(name, email, password);
        database.AddUser(user);
    }

    public static User Login(Database database)
    {
        User user = null ;
        AnsiConsole.MarkupLine("[bold green]Login[/]");
        var email = AnsiConsole.Ask<string>("Email: ");
        var password = AnsiConsole.Ask<string>("Password: ");
        if (database.isUserInDatabase(email, password))
        {
            user = database.GetUser(email, password);
            AnsiConsole.MarkupLine("[bold green]You are logged in![/]");
            AnsiConsole.MarkupLine("[bold green]Press any key to continue...[/]");
            Console.ReadKey();
        }else{
            AnsiConsole.MarkupLine("[bold red]Wrong email or password![/]");
            Login(database);
        }

        return user;
    }

    public static void SendMessage(Database database, User user)
    {
        AnsiConsole.MarkupLine("[bold green]Send message[/]");
        var receiver = AnsiConsole.Ask<string>("Receiver: ");
        var text = AnsiConsole.Ask<string>("Text: ");
        var message = new Message(text, 1, 2, DateTime.Now);
        database.SendMessage(message);
    }

    public static void ListMessages(Database database, User user)
    {
        AnsiConsole.MarkupLine("[bold green]List messages[/]");
        var messages = database.GetMessages(user);
        foreach (var message in messages)
        {
            AnsiConsole.MarkupLine($"[bold green]{message}[/]");
        }
        AnsiConsole.MarkupLine("[bold green]Press any key to continue...[/]");
        Console.ReadKey();
    }
}