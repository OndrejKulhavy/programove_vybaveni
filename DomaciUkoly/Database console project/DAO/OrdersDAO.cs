using Microsoft.Data.SqlClient;

class OrdersDAO : IDAO<Order>
{
    private Database database;

    public OrdersDAO(Database database)
    {
        this.database = database;
    }

    public void Add(Order order)
    {
        string sql = "INSERT INTO orders (name, date, has_arrived, price, report_id) VALUES (@name, @date, @has_arrived, @price, @report_id)";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@name", order.Name);
        command.Parameters.AddWithValue("@date", order.Date);
        command.Parameters.AddWithValue("@has_arrived", order.HasArrived);
        command.Parameters.AddWithValue("@price", order.Price);
        command.Parameters.AddWithValue("@report_id", order.ReportID);
        command.ExecuteNonQuery();
    }
    public void Update(Order order)
    {
        string sql = "UPDATE orders SET name = @name, date = @date, has_arrived = @has_arrived, price = @price, report_id = @report_id WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@name", order.Name);
        command.Parameters.AddWithValue("@date", order.Date);
        command.Parameters.AddWithValue("@has_arrived", order.HasArrived);
        command.Parameters.AddWithValue("@price", order.Price);
        command.Parameters.AddWithValue("@report_id", order.ReportID);
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        string sql = "DELETE FROM orders WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", id);
        command.ExecuteNonQuery();
    }


    public List<Order> GetAll()
    {
        List<Order> orders = new List<Order>();
        string sql = "SELECT * FROM orders";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            //bool hasArrived = reader.GetByte(3) == 1;

            Order order = new Order(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetDateTime(2),
                reader.GetInt32(5),
                reader.GetBoolean(3),
                reader.GetFloat(4)
            );
            orders.Add(order);
        }
        reader.Close();
        return orders;
    }

    public Order GetById(int id)
    {
        string sql = "SELECT * FROM orders WHERE id = @id";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.Parameters.AddWithValue("@id", id);
        SqlDataReader reader = command.ExecuteReader();
        reader.Read();
        Order order = new Order(
            reader.GetInt32(0),
            reader.GetString(1),
            reader.GetDateTime(2),
            reader.GetInt32(4),
            reader.GetBoolean(3),
            reader.GetInt32(5)
        );
        reader.Close();
        return order;
    }
    
    public bool hasTable()
    {
        string sql = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'orders'";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        SqlDataReader reader = command.ExecuteReader();
        bool hasTable = reader.HasRows;
        reader.Close();
        return hasTable;
    }

    public void CreateTable()
    {
        string sql = "CREATE TABLE orders(id int PRIMARY KEY IDENTITY(1,1) not NULL, name varchar(50) not NULL, date date not NULL, has_arrived bit not NULL, price FLOAT not NULL, report_id int not NULL FOREIGN KEY REFERENCES reports(id))";
        SqlCommand command = new SqlCommand(sql, database.Connection);
        command.ExecuteNonQuery();
    }

}