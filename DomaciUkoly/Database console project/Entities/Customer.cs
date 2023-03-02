using System.Text.Json.Serialization;
class Customer
{
    [JsonIgnore]
    public int Id { get; set; }
    [JsonInclude]
    public string FirstName { get; set; }
    [JsonInclude]
    public string LastName { get; set; }
    [JsonInclude]
    public string Address { get; set; }
    [JsonInclude]
    public string City { get; set; }
    [JsonInclude]
    public string Country { get; set; }
    [JsonInclude]
    public string Zip { get; set; }
    [JsonInclude]
    public int Phone { get; set; }
    [JsonInclude]
    public string Email { get; set; }

    public Customer(string firstName, string lastName, string address, string city, string country, string zip, int phone, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        Country = country;
        Zip = zip;
        Phone = phone;
        Email = email;
    }
    public Customer(int id, string firstName, string lastName, string address, string city, string country, string zip, int phone, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        Country = country;
        Zip = zip;
        Phone = phone;
        Email = email;
    }
}