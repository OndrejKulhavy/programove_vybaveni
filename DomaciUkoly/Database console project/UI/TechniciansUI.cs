using Spectre.Console;

class TechniciansUI
{
    private TechniciansDAO techniciansDAO;

    public TechniciansUI(Database database)
    {
        techniciansDAO = new TechniciansDAO(database);
    }

    public void Add()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Add technician[/]");
        var firstName = AnsiConsole.Ask<string>("First name: ");
        var lastName = AnsiConsole.Ask<string>("Last name: ");
        var phone = AnsiConsole.Ask<int>("Phone: ");
        var email = AnsiConsole.Ask<string>("Email: ");
        var salary = AnsiConsole.Ask<int>("Hourly rate: ");
        var position = AnsiConsole.Ask<string>("Position: ");
        var hired = AnsiConsole.Ask<DateTime>("Hired: ");
        var adress = AnsiConsole.Ask<string>("Adress: ");
        var city = AnsiConsole.Ask<string>("City: ");
        var zip = AnsiConsole.Ask<string>("Zip: ");
        var country = AnsiConsole.Ask<string>("Country: ");


        try
        {
            techniciansDAO.Add(new Technician(firstName, lastName, adress, city, country, zip, phone, email, position, salary, hired));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Technician added[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Edit()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Edit technician[/]");

        string firstName = AnsiConsole.Ask<string>("First name: ");
        string lastName = AnsiConsole.Ask<string>("Last name: ");


        int id = techniciansDAO.GetIdByName(firstName, lastName);
        if (id == 0)
        {
            AnsiConsole.MarkupLine("[red]Error: Technician not found[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }

        AnsiConsole.MarkupLine("[green]Technician found[/]");

        firstName = AnsiConsole.Ask<string>("First name: ");
        lastName = AnsiConsole.Ask<string>("Last name: ");
        var phone = AnsiConsole.Ask<int>("Phone: ");
        var email = AnsiConsole.Ask<string>("Email: ");
        var salary = AnsiConsole.Ask<int>("Hourly rate: ");
        var position = AnsiConsole.Ask<string>("Position: ");
        var hired = AnsiConsole.Ask<DateTime>("Hired: ");
        var adress = AnsiConsole.Ask<string>("Adress: ");
        var city = AnsiConsole.Ask<string>("City: ");
        var zip = AnsiConsole.Ask<string>("Zip: ");
        var country = AnsiConsole.Ask<string>("Country: ");

        try
        {
            techniciansDAO.Update(new Technician(id, firstName, lastName, adress, city, country, zip, phone, email, position, salary, hired));
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }

        AnsiConsole.MarkupLine("[green]Technician edited[/]");
        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Delete()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Delete technician[/]");
        var id = AnsiConsole.Ask<int>("Id: ");
        try
        {
            techniciansDAO.Delete(id);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine("[red]Error: " + e.Message + "[/]");
            AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine("[green]Technician deleted[/]");
    }

    public void List()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Technicians[/]");
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("First name");
        table.AddColumn("Last name");
        table.AddColumn("Phone");
        table.AddColumn("Email");
        table.AddColumn("Hourly rate");
        table.AddColumn("Position");
        table.AddColumn("Hired");
        table.AddColumn("Adress");
        table.AddColumn("City");
        table.AddColumn("Zip");
        table.AddColumn("Country");
        foreach (var technician in techniciansDAO.GetAll())
        {
            table.AddRow(technician.Id.ToString(), technician.FirstName, technician.LastName, technician.Phone.ToString(), technician.Email, technician.HourlyRate.ToString(), technician.Position, technician.DateHired.ToString(), technician.Address, technician.City, technician.Zip, technician.Country);
        }
        AnsiConsole.Write(table);

        AnsiConsole.MarkupLine("[grey]Press any key to continue...[/]");
        Console.ReadKey();
    }


}