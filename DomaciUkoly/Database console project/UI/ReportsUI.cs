using Spectre.Console;

class ReportsUI
{
    private ReportsDAO reportsDAO;

    public ReportsUI(Database database)
    {
        reportsDAO = new ReportsDAO(database);
    }

    public void Add(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Add report[/]");
        var date = AnsiConsole.Ask<DateTime>("Date: ");
        var description = AnsiConsole.Ask<string>("Description: ");
        var price = AnsiConsole.Ask<float>("Price: ");
        var reportID = AnsiConsole.Ask<int>("Report ID: ");
        var vehicleID = AnsiConsole.Ask<int>("Vehicle ID: ");
        var technicianID = AnsiConsole.Ask<int>("Technician ID: ");
        var customerId = AnsiConsole.Ask<int>("Customer ID: ");
        try
        {
            reportsDAO.Add(new Report(date,description,price, customerId,vehicleID,technicianID));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");

            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Report added[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Edit(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Edit report[/]");
        var id = AnsiConsole.Ask<int>("Id: ");
        var date = AnsiConsole.Ask<DateTime>("Date: ");
        var description = AnsiConsole.Ask<string>("Description: ");
        var price = AnsiConsole.Ask<float>("Price: ");
        var reportID = AnsiConsole.Ask<int>("Report ID: ");
        var vehicleID = AnsiConsole.Ask<int>("Vehicle ID: ");
        var technicianID = AnsiConsole.Ask<int>("Technician ID: ");
        var customerId = AnsiConsole.Ask<int>("Customer ID: ");
        try
        {
            reportsDAO.Update(new Report(id,date,description,price, customerId,vehicleID,technicianID));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Report updated[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Delete(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Delete report[/]");
        var id = AnsiConsole.Ask<int>("Id: ");
        try
        {
            reportsDAO.Delete(id);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Report deleted[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void List(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Reports[/]");
        var reports = reportsDAO.GetAll();
        var table = new Table();
        table.AddColumn("ID");
        table.AddColumn("Date");
        table.AddColumn("Description");
        table.AddColumn("Price");
        table.AddColumn("Customer ID");
        table.AddColumn("Vehicle ID");
        table.AddColumn("Technician ID");
        foreach (var report in reports)
        {
            table.AddRow(report.Id.ToString(), report.Date.ToString(), report.Description, report.Price.ToString(), report.CustomerId.ToString(), report.VehicleId.ToString(), report.TechnicianId.ToString());
        }
        AnsiConsole.Write(table);

        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }
}