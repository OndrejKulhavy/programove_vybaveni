using Spectre.Console;

class CustomersUI
{
    private CustomersDAO customersDAO;

    public CustomersUI(Database database)
    {
        customersDAO = new CustomersDAO(database);
    }

    public void Add()
    {
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Add customer[/]");
        AnsiConsole.MarkupLine("");
        string firstName = AnsiConsole.Ask<string>("Enter the customer's first name:");
        string lastName = AnsiConsole.Ask<string>("Enter the customer's last name:");
        string email = AnsiConsole.Ask<string>("Enter the customer's email:");
        int phone = AnsiConsole.Ask<int>("Enter the customer's phone number:");
        string address = AnsiConsole.Ask<string>("Enter the customer's address:");
        string city = AnsiConsole.Ask<string>("Enter the customer's city:");
        string country = AnsiConsole.Ask<string>("Enter the customer's country:");
        string zip = AnsiConsole.Ask<string>("Enter the customer's zip code:");

        Customer customer = new Customer(firstName, lastName, address, city, country, zip, phone, email);
        try
        {
            customersDAO.Add(customer);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine($"[red]Error: {e.Message}[/]");
            return;
        }
        AnsiConsole.MarkupLine($"[green]Customer {customer.FirstName} {customer.LastName} added successfully.[/]");
        AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Edit(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Edit customer[/]");
        AnsiConsole.MarkupLine("");
        string firstName = AnsiConsole.Ask<string>("Enter the customer's first name:");
        string lastName = AnsiConsole.Ask<string>("Enter the customer's last name:");

        int id = 0;
        id = customersDAO.GetIdByName(firstName, lastName);
        if (id == 0)
        {
            AnsiConsole.MarkupLine("[red]Customer not found.[/]");
            AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        AnsiConsole.MarkupLine($"[green]Customer found:[/]");

        int phone = AnsiConsole.Ask<int>("Enter the customer's phone number:");
        string address = AnsiConsole.Ask<string>("Enter the customer's address:");
        string city = AnsiConsole.Ask<string>("Enter the customer's city:");
        string country = AnsiConsole.Ask<string>("Enter the customer's country:");
        string zip = AnsiConsole.Ask<string>("Enter the customer's zip code:");
        string email = AnsiConsole.Ask<string>("Enter the customer's email:");

        Customer customer = new Customer(id, firstName, lastName, address, city, country, zip, phone, email);
        try
        {
            customersDAO.Update(customer);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine($"[red]Error: {e.Message}[/]");
            return;
        }

        AnsiConsole.MarkupLine($"[green]Customer {customer.FirstName} {customer.LastName} edited successfully.[/]");
        AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void List(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]List customers[/]");
        AnsiConsole.MarkupLine("");
        List<Customer> customers = customersDAO.GetAll();
        if (customers.Count == 0)
        {
            AnsiConsole.MarkupLine("[red]No customers found.[/]");
            AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        var table = new Table();
        table.AddColumn("ID");
        table.AddColumn("First name");
        table.AddColumn("Last name");
        table.AddColumn("Email");
        table.AddColumn("Phone");
        table.AddColumn("Address");
        table.AddColumn("City");
        table.AddColumn("Country");
        table.AddColumn("Zip");
        foreach (Customer customer in customers)
        {
            table.AddRow(customer.Id.ToString(), customer.FirstName, customer.LastName, customer.Email, customer.Phone.ToString(), customer.Address, customer.City, customer.Country, customer.Zip);
        }
        AnsiConsole.Write(table);
        AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void Delete(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Delete customer[/]");
        AnsiConsole.MarkupLine("");
        string firstName = AnsiConsole.Ask<string>("Enter the customer's first name:");
        string lastName = AnsiConsole.Ask<string>("Enter the customer's last name:");

        var id = customersDAO.GetIdByName(firstName, lastName);
        if (id == 0)
        {
            AnsiConsole.MarkupLine("[red]Customer not found.[/]");
            AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
            Console.ReadKey();
            return;
        }
        try
        {
            customersDAO.Delete(id);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine($"[red]Error: {e.Message}[/]");
            return;
        }
        AnsiConsole.MarkupLine($"[green]Customer {firstName} {lastName} deleted successfully.[/]");
        AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
        Console.ReadKey();
    }

    public void AddFromJSON(){
        AnsiConsole.Clear();
        AnsiConsole.MarkupLine("[underline]Add customers from JSON[/]");
        AnsiConsole.MarkupLine("");
        string path = AnsiConsole.Ask<string>("Enter the path to the JSON file:");
        try
        {
            customersDAO.AddFromJSON(path);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLine($"[red]Error: {e.Message}[/]");
            return;
        }
        AnsiConsole.MarkupLine($"[green]Customers added successfully.[/]");
        AnsiConsole.MarkupLine("[gray]Press any key to continue...[/]");
        Console.ReadKey();
    }
}