using Spectre.Console;
class Menu
{
    Database database;
    bool run = true;
    public bool Run { get => run; set => run = value; }
    public Menu(Database database)
    {
        this.database = database;

        do{
            MainMenu();
        }while(run);
    }

    public void MainMenu()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Menu[/]");
        var section = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Choose a section")
        .PageSize(10)
        .AddChoices(new[] {
            "Customers",
            "Orders",
            "Reports",
            "Technicians",
            "Vehicles",
            "[red]Exit[/]"
        }));
        
        switch (section)
        {
            case "Customers":
                CustomersMenu();
                break;
            case "Orders":
                OrdersMenu();
                break;
            case "Reports":
                ReportsMenu();
                break;
            case "Technicians":
                TechniciansMenu();
                break;
            case "Vehicles":
                VehiclesMenu();
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }

    public void CustomersMenu()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Customers[/]");
        var section = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Choose a section")
        .PageSize(10)
        .AddChoices(new[] {
            "Add customer",
            "Edit customer",
            "Delete customer",
            "List customers",
            "Add from JSON",
            "[red]<- Back[/]"
        }));

        switch (section)
        {
            case "Add customer":
                new CustomersUI(database).Add();
                break;
            case "Edit customer":
                new CustomersUI(database).Edit();
                break;
            case "Delete customer":
                new CustomersUI(database).Delete();
                break;
            case "List customers":
                new CustomersUI(database).List();
                break;
            case "Add from JSON":
                new CustomersUI(database).AddFromJSON();
                break;
            case "<- Back":
                MainMenu();
                break;
            default:
                break;
        }
    }

    public void OrdersMenu()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Orders[/]");
        var section = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Choose a section")
        .PageSize(10)
        .AddChoices(new[] {
            "Add order",
            "Edit order",
            "Delete order",
            "List orders",
            "[red]<- Back[/]"
        }));
        switch (section)
        {
            case "Add order":
                new OrdersUI(database).Add();
                break;
            case "Edit order":
                new OrdersUI(database).Edit();
                break;
            case "Delete order":
                new OrdersUI(database).Delete();
                break;
            case "List orders":
                new OrdersUI(database).List();
                break;
            case "<- Back":
                MainMenu();
                break;
            default:
                break;
        }
    }

    public void ReportsMenu()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Reports[/]");
        var section = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Choose a section")
        .PageSize(10)
        .AddChoices(new[] {
            "Add report",
            "Edit report",
            "Delete report",
            "List reports",
            "[red]<- Back[/]"
        }));

        switch (section)
        {
            case "Add report":
                new ReportsUI(database).Add();
                break;
            case "Edit report":
                new ReportsUI(database).Edit();
                break;
            case "Delete report":
                new ReportsUI(database).Delete();
                break;
            case "List reports":
                new ReportsUI(database).List();
                break;
            case "<- Back":
                MainMenu();
                break;
            default:
                break;
        }

    }

    public void TechniciansMenu()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Technicians[/]");
        var section = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Choose a section")
        .PageSize(10)
        .AddChoices(new[] {
            "Add technician",
            "Edit technician",
            "Delete technician",
            "List technicians",
            "[red]<- Back[/]"
        }));

        switch (section)
        {
            case "Add technician":
                new TechniciansUI(database).Add();
                break;
            case "Edit technician":
                new TechniciansUI(database).Edit();
                break;
            case "Delete technician":
                new TechniciansUI(database).Delete();
                break;
            case "List technicians":
                new TechniciansUI(database).List();
                break;
            case "<- Back":
                MainMenu();
                break;
            default:
                break;
        }
    }

    public void VehiclesMenu()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Vehicles[/]");
        var section = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Choose a section")
        .PageSize(10)
        .AddChoices(new[] {
            "Add vehicle",
            "Edit vehicle",
            "Delete vehicle",
            "List vehicles",
            "[red]<- Back[/]"
        }));

        switch (section)
        {
            case "Add vehicle":
                new VehiclesUI(database).Add();
                break;
            case "Edit vehicle":
                new VehiclesUI(database).Edit();
                break;
            case "Delete vehicle":
                new VehiclesUI(database).Delete();
                break;
            case "List vehicles":
                new VehiclesUI(database).List();
                break;
            case "<- Back":
                MainMenu();
                break;
            default:
                break;
        }
    }
}