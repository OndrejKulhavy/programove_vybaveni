using Microsoft.Data.SqlClient;

class ReportsDAO : IDAO<Report>
{
    private Database database;

    public ReportsDAO(Database database)
    {
        this.database = database;
    }

    public void Add(Report report)
    {
        string sql = "INSERT INTO reports (date, description, price, customer_id, technician_id, vehicle_id) VALUES (@date, @description, @price, @customer_id, @technician_id, @vehicle_id)";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@date", report.Date);
        command.Parameters.AddWithValue("@description", report.Description);
        command.Parameters.AddWithValue("@price", report.Price);
        command.Parameters.AddWithValue("@customer_id", report.CustomerId);
        command.Parameters.AddWithValue("@technician_id", report.TechnicianId);
        command.Parameters.AddWithValue("@vehicle_id", report.VehicleId);
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        string sql = "DELETE FROM reports WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", id);
        command.ExecuteNonQuery();
    }

    public void Update(Report report)
    {
        string sql = "UPDATE reports SET date = @date, description = @description, price = @price, customer_id = @customer_id, technician_id = @technician_id, vehicle_id = @vehicle_id WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@date", report.Date);
        command.Parameters.AddWithValue("@description", report.Description);
        command.Parameters.AddWithValue("@price", report.Price);
        command.Parameters.AddWithValue("@customer_id", report.CustomerId);
        command.Parameters.AddWithValue("@technician_id", report.TechnicianId);
        command.Parameters.AddWithValue("@vehicle_id", report.VehicleId);
        command.ExecuteNonQuery();
    }

    public List<Report> GetAll()
    {
        List<Report> reports = new List<Report>();
        string sql = "SELECT * FROM reports";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Report report = new Report(
                reader.GetInt32(0),
                reader.GetDateTime(1),
                reader.GetString(2),
                reader.GetFloat(3),
                reader.GetInt32(4),
                reader.GetInt32(5),
                reader.GetInt32(6)
            );
            reports.Add(report);
        }
        reader.Close();
        return reports;
    }

    public bool hasTable()
    {
        string sql = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'reports'";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        bool hasTable = reader.HasRows;
        reader.Close();
        return hasTable;
    }

    public void CreateTable()
    {
        string sql = "CREATE TABLE reports (id int PRIMARY KEY IDENTITY(1,1) not NULL, date date not NULL, description varchar(200) not NULL, price FLOAT not NULL, customer_id int not NULL FOREIGN KEY REFERENCES customers(id), technician_id int not NULL FOREIGN KEY REFERENCES technicians(id), vehicle_id int not NULL FOREIGN KEY REFERENCES vehicles(id));";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.ExecuteNonQuery();
    }


}