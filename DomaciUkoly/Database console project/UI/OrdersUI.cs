using Spectre.Console;

class OrdersUI
{
    private OrdersDAO ordersDAO;

    public OrdersUI(Database database)
    {
        ordersDAO = new OrdersDAO(database);
    }

    public void Add(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Add order[/]");
        var name = AnsiConsole.Ask<string>("Name: ");
        var date = AnsiConsole.Ask<DateTime>("Date: ");
        var hasArrived = AnsiConsole.Ask<bool>("Has arrived: ");
        var price = AnsiConsole.Ask<float>("Price: ");
        var reportID = AnsiConsole.Ask<int>("Report ID: ");
        try
        {
            ordersDAO.Add(new Order(name, date, reportID, hasArrived, price));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");

            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Order added[/]");
    }

    public void Edit(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Edit order[/]");
        var id = AnsiConsole.Ask<int>("Id: ");
        var name = AnsiConsole.Ask<string>("Name: ");
        var date = AnsiConsole.Ask<DateTime>("Date: ");
        var hasArrived = AnsiConsole.Ask<bool>("Has arrived: ");
        var price = AnsiConsole.Ask<float>("Price: ");
        var reportID = AnsiConsole.Ask<int>("Report ID: ");
        try
        {
            ordersDAO.Update(new Order(id, name, date, reportID, hasArrived, price));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Order updated[/]");
    }

    public void Delete(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Delete order[/]");
        var id = AnsiConsole.Ask<int>("Id: ");
        try
        {
            ordersDAO.Delete(id);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Order deleted[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void List(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Orders[/]");
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Name");
        table.AddColumn("Price");
        table.AddColumn("Has arrived");
        table.AddColumn("Date");
        foreach (var order in ordersDAO.GetAll())
        {
            table.AddRow(
                order.Id.ToString(),
                order.Name,
                order.Price.ToString(),
                order.HasArrived ? "Yes" : "No",
                order.Date.ToString()
            );
        }
        AnsiConsole.Write(table);
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }
}