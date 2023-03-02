using Microsoft.Data.SqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;
class CustomersDAO : IDAO<Customer>
{
    private Database database;
    public CustomersDAO(Database database)
    {
        this.database = database;
    }

    public void Add(Customer customer)
    {
        string sql = "INSERT INTO customers (first_name, last_name, adress, city, country, zip_code, phone, email) VALUES (@first_name, @last_name, @adress, @city, @country, @zip_code, @phone, @email)";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@first_name", customer.FirstName);
        command.Parameters.AddWithValue("@last_name", customer.LastName);
        command.Parameters.AddWithValue("@adress", customer.Address);
        command.Parameters.AddWithValue("@city", customer.City);
        command.Parameters.AddWithValue("@country", customer.Country);
        command.Parameters.AddWithValue("@zip_code", customer.Zip);
        command.Parameters.AddWithValue("@phone", customer.Phone);
        command.Parameters.AddWithValue("@email", customer.Email);
        command.ExecuteNonQuery();
    }
    public void Update(Customer customer)
    {
        string sql = "UPDATE customers SET first_name = @first_name, last_name = @last_name, adress = @adress, city = @city, country = @country, zip_code = @zip_code, phone = @phone, email = @email WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", customer.Id);
        command.Parameters.AddWithValue("@first_name", customer.FirstName);
        command.Parameters.AddWithValue("@last_name", customer.LastName);
        command.Parameters.AddWithValue("@adress", customer.Address);
        command.Parameters.AddWithValue("@city", customer.City);
        command.Parameters.AddWithValue("@country", customer.Country);
        command.Parameters.AddWithValue("@zip_code", customer.Zip);
        command.Parameters.AddWithValue("@phone", customer.Phone);
        command.Parameters.AddWithValue("@email", customer.Email);
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        string sql = "DELETE FROM customers WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", id);
        command.ExecuteNonQuery();
    }

    public List<Customer> GetAll()
    {
        List<Customer> customers = new List<Customer>();
        string sql = "SELECT * FROM customers";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Customer customer = new Customer(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3),
                reader.GetString(4),
                reader.GetString(5),
                reader.GetString(6),
                reader.GetInt32(7),
                reader.GetString(8)
            );
            customers.Add(customer);
        }
        reader.Close();
        return customers;
    }

    public Customer GetById(int id)
    {
        string sql = "SELECT * FROM customers WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", id);
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        Customer customer = new Customer(
            reader.GetInt32(0),
            reader.GetString(1),
            reader.GetString(2),
            reader.GetString(3),
            reader.GetString(4),
            reader.GetString(5),
            reader.GetString(6),
            reader.GetInt32(7),
            reader.GetString(8)
        );
        reader.Close();
        return customer;
    }

    public int GetIdByName(string firstName, string lastName)
    {
        string sql = "SELECT id FROM customers WHERE first_name = @first_name AND last_name = @last_name";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@first_name", firstName);
        command.Parameters.AddWithValue("@last_name", lastName);
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        int id = reader.GetInt32(0);
        reader.Close();
        return id;
    }

    public bool hasTable()
    {
        string sql = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'customers'";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        bool hasRows = reader.HasRows;
        reader.Close();
        return hasRows;
    }

    public void CreateTable()
    {
        string sql = "CREATE TABLE customers(id int PRIMARY KEY IDENTITY(1,1) not NULL, first_name varchar(50) not NULL, last_name varchar(50) not NULL, adress varchar(50) not NULL, city varchar(50) not NULL, country varchar(50) not NULL, zip_code varchar(50) not NULL, phone int not NULL, email varchar(50) not NULL);";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.ExecuteNonQuery();
    }

    public void AddFromJSON(string path)
    {
        string jsonString = File.ReadAllText(path);
        var customers = JsonSerializer.Deserialize<List<Customer>>(jsonString);
        foreach (Customer customer in customers)
        {
            Add(customer);
        }
    
    }

}