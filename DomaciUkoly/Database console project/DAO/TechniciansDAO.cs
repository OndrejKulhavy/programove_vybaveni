using Microsoft.Data.SqlClient;
class TechniciansDAO : IDAO<Technician>
{
    private Database database;
    public TechniciansDAO(Database database)
    {
        this.database = database;
    }

    public void Add(Technician technician)
    {
        string sql = "INSERT INTO technicians (first_name, last_name, adress, city, country, zip_code, phone, email, position, hourly_rate, hired) VALUES (@first_name, @last_name, @adress, @city, @country, @zip_code, @phone, @email, @position, @hourly_rate, @hired)";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@first_name", technician.FirstName);
        command.Parameters.AddWithValue("@last_name", technician.LastName);
        command.Parameters.AddWithValue("@adress", technician.Address);
        command.Parameters.AddWithValue("@city", technician.City);
        command.Parameters.AddWithValue("@country", technician.Country);
        command.Parameters.AddWithValue("@zip_code", technician.Zip);
        command.Parameters.AddWithValue("@phone", technician.Phone);
        command.Parameters.AddWithValue("@email", technician.Email);
        command.Parameters.AddWithValue("@position", technician.Position);
        command.Parameters.AddWithValue("@hourly_rate", technician.HourlyRate);
        command.Parameters.AddWithValue("@hired", technician.DateHired);
        command.ExecuteNonQuery();
    }
    public void Delete(int id)
    {
        string sql = "DELETE FROM technicians WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", id);
        command.ExecuteNonQuery();
    }

    public void Update(Technician technician)
    {
        string sql = "UPDATE technicians SET first_name = @first_name, last_name = @last_name, adress = @adress, city = @city, country = @country, zip_code = @zip_code, phone = @phone, email = @email, position = @position, hourly_rate = @hourly_rate, hired = @hired WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@first_name", technician.FirstName);
        command.Parameters.AddWithValue("@last_name", technician.LastName);
        command.Parameters.AddWithValue("@adress", technician.Address);
        command.Parameters.AddWithValue("@city", technician.City);
        command.Parameters.AddWithValue("@country", technician.Country);
        command.Parameters.AddWithValue("@zip_code", technician.Zip);
        command.Parameters.AddWithValue("@phone", technician.Phone);
        command.Parameters.AddWithValue("@email", technician.Email);
        command.Parameters.AddWithValue("@position", technician.Position);
        command.Parameters.AddWithValue("@hourly_rate", technician.HourlyRate);
        command.Parameters.AddWithValue("@hired", technician.DateHired);
        command.ExecuteNonQuery();
    }
    public int GetIdByName(string firstName, string lastName)
    {
        string sql = "SELECT id FROM technicians WHERE first_name = @first_name AND last_name = @last_name";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@first_name", firstName);
        command.Parameters.AddWithValue("@last_name", lastName);
        SqlDataReader reader = command.ExecuteReader();
        int id = 0;
        while (reader.Read())
        {
            id = reader.GetInt32(0);
        }
        reader.Close();
        return id;
    }

    public List<Technician> GetAll()
    {
        string sql = "SELECT * FROM technicians";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        List<Technician> technicians = new List<Technician>();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string firstName = reader.GetString(1);
            string lastName = reader.GetString(2);
            string address = reader.GetString(3);
            string city = reader.GetString(4);
            string country = reader.GetString(5);
            string zip = reader.GetString(6);
            int phone = reader.GetInt32(7);
            string email = reader.GetString(8);
            string position = reader.GetString(9);
            int hourlyRate = reader.GetInt32(10);
            DateTime dateHired = reader.GetDateTime(11);
            Technician technician = new Technician(id, firstName, lastName, address, city, country, zip, phone, email, position, hourlyRate, dateHired);
            technicians.Add(technician);
        }
        reader.Close();
        return technicians;
    }

    public bool hasTable()
    {
        string sql = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'technicians'";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        bool hasTable = false;
        while (reader.Read())
        {
            hasTable = true;
        }
        reader.Close();
        return hasTable;
    }

    public void CreateTable()
    {
        string sql = "CREATE TABLE technicians (id int PRIMARY KEY IDENTITY(1,1) not NULL, first_name varchar(50) not NULL, last_name varchar(50) not NULL, adress varchar(50) not NULL, city varchar(50) not NULL, country varchar(50) not NULL, zip_code varchar(50) not NULL, phone int not NULL, email varchar(50) not NULL, position varchar(50) not NULL, hourly_rate int not NULL, hired date not NULL);";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.ExecuteNonQuery();
    }
}