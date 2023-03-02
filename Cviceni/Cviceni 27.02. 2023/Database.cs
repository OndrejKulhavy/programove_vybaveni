using Microsoft.Data.SqlClient;
using System.Configuration;
public class Database
{
    private SqlConnection connection;


    public Database()
    {
        try
        {
            Connect();
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Connect()
    {
        var connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        Console.WriteLine(connectionString);
        connection = new SqlConnection(connectionString);
        connection.Open();
    }

    public bool isUserInDatabase(string email, string password)
    {
        var query = $"SELECT * FROM Users WHERE email = '{email}' AND password = '{password}'";
        var command = new SqlCommand(query, connection);
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            reader.Close();
            return true;
        }
        reader.Close();
        return false;
    }
    
    public User GetUser(string email, string password){
        var query = $"SELECT * FROM Users WHERE email = '{email}' AND password = '{password}'";
        var command = new SqlCommand(query, connection);
        var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            reader.Read();
            int id = reader.GetInt32(0);
            var name = reader.GetString(1);
            var user = new User(id, name, email, password);
            reader.Close();
            return user;
        }
        reader.Close();
        return null;
    }

    public void AddUser(User user)
    {
        var query = $"INSERT INTO Users (name, email, password) VALUES ('{user.Name}', '{user.Email}', '{user.Password}')";
        var command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();
    }

    public void RemoveUser(User user)
    {
        var query = $"DELETE FROM Users WHERE email = '{user.Email}' AND password = '{user.Password}' AND name = '{user.Name}'";
        var command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();
    }

    public void SendMessage(Message message)
    {
        var query = $"INSERT INTO messages (text, sender_id, receiver_id, time) VALUES ('{message.Text}', {message.SenderID}, {message.ReceiverID}, '{message.Time.ToString("yyyy-MM-dd")}')";
        var command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();
    }

    public List<Message> GetMessages (User user){
        var query = $"SELECT * FROM messages WHERE receiver_id = {user.ID}";
        var command = new SqlCommand(query, connection);
        var reader = command.ExecuteReader();
        var messages = new List<Message>();
        while (reader.Read())
        {

            var time = reader.GetDateTime(1);
            var text = reader.GetString(2);
            var sender = reader.GetInt32(3);
            var receiver = reader.GetInt32(4);
            var message = new Message(text, sender, receiver, time);
            messages.Add(message);
        }
        reader.Close();
        return messages;
    }



    public void Close()
    {
        connection.Close();
    }

}