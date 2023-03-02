using Microsoft.Data.SqlClient;

class VehiclesDAO : IDAO<Vehicle>
{
    private Database database;

    public VehiclesDAO(Database database)
    {
        this.database = database;
    }

    public void Add(Vehicle vehicle)
    {
        string sql = "INSERT INTO vehicles (company, model, year, vin, customer_id) VALUES (@company, @model, @year, @vin, @customer_id)";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@company", vehicle.Company);
        command.Parameters.AddWithValue("@model", vehicle.Model);
        command.Parameters.AddWithValue("@year", vehicle.YearOfManufacture);
        command.Parameters.AddWithValue("@vin", vehicle.Vin);
        command.Parameters.AddWithValue("@customer_id", vehicle.CustomerId);
        command.ExecuteNonQuery();
    }
    public void Update(Vehicle vehicle)
    {
        string sql = "UPDATE vehicles SET company = @company, model = @model, year = @year, vin = @vin, customer_id = @customer_id WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@company", vehicle.Company);
        command.Parameters.AddWithValue("@model", vehicle.Model);
        command.Parameters.AddWithValue("@year", vehicle.YearOfManufacture);
        command.Parameters.AddWithValue("@vin", vehicle.Vin);
        command.Parameters.AddWithValue("@customer_id", vehicle.CustomerId);
        command.Parameters.AddWithValue("@id", vehicle.Id);
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        string sql = "DELETE FROM vehicles WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", id);
        command.ExecuteNonQuery();
    }


    public List<Vehicle> GetAll()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        string sql = "SELECT * FROM vehicles";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Vehicle vehicle = new Vehicle(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetInt32(3),
                reader.GetString(4),
                reader.GetInt32(5)
            );
            vehicles.Add(vehicle);
        }
        reader.Close();
        return vehicles;
    }

    public bool hasTable()
    {
        string sql = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'vehicles'";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        bool hasTable = reader.HasRows;
        reader.Close();
        return hasTable;
    }

    public void CreateTable()
    {
        string sql = "CREATE TABLE vehicles (id int PRIMARY KEY IDENTITY(1,1) not NULL, company varchar(50) not NULL, model varchar(50) not NULL, year int not NULL, vin varchar(50) not NULL, customer_id int not NULL FOREIGN KEY REFERENCES customers(id));";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.ExecuteNonQuery();
    }


}