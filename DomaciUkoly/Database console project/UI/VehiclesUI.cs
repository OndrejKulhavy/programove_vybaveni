using Spectre.Console;

class VehiclesUI
{
    private VehiclesDAO vehiclesDAO;

    public VehiclesUI(Database database)
    {
        vehiclesDAO = new VehiclesDAO(database);
    }

    public void Add(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Add vehicle[/]");
        var brand = AnsiConsole.Ask<string>("Brand: ");
        var model = AnsiConsole.Ask<string>("Model: ");
        var year = AnsiConsole.Ask<int>("Year: ");
        var vin = AnsiConsole.Ask<string>("VIN number: ");
        var customerId = AnsiConsole.Ask<int>("Customer ID: ");
        try
        {
            vehiclesDAO.Add(new Vehicle(brand,model,year,vin,customerId));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");

            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Vehicle added[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Edit(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Edit vehicle[/]");
        var id = AnsiConsole.Ask<int>("Id: ");
        var brand = AnsiConsole.Ask<string>("Brand: ");
        var model = AnsiConsole.Ask<string>("Model: ");
        var year = AnsiConsole.Ask<int>("Year: ");
        var vin = AnsiConsole.Ask<string>("VIN number: ");
        var customerId = AnsiConsole.Ask<int>("Customer ID: ");
        try
        {
            vehiclesDAO.Update(new Vehicle(id, brand, model, year, vin, customerId));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Vehicle updated[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Delete(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Delete vehicle[/]");
        var id = AnsiConsole.Ask<int>("Id: ");
        try
        {
            vehiclesDAO.Delete(id);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Vehicle deleted[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void List(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Vehicles[/]");
        var vehicles = vehiclesDAO.GetAll();
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Brand");
        table.AddColumn("Model");
        table.AddColumn("Year");
        table.AddColumn("Customer ID");
        foreach (var vehicle in vehicles)
        {
            table.AddRow(vehicle.Id.ToString(), vehicle.Company, vehicle.Model, vehicle.YearOfManufacture.ToString(), vehicle.CustomerId.ToString());
        }
        AnsiConsole.Write(table);
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }
}