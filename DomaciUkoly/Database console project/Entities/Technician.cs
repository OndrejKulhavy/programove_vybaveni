class Technician
{
    public int Id{ get;set;}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Zip { get; set; }
    public int Phone { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public int HourlyRate { get; set; }
    public DateTime DateHired { get; set; }

    public Technician(int id, string firstName, string lastName, string address, string city, string country, string zip, int phone, string email, string position, int hourlyRate, DateTime dateHired)
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
        Position = position;
        HourlyRate = hourlyRate;
        DateHired = dateHired;
    }

    public Technician(string firstName, string lastName, string address, string city, string country, string zip, int phone, string email, string position, int hourlyRate, DateTime dateHired)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        Country = country;
        Zip = zip;
        Phone = phone;
        Email = email;
        Position = position;
        HourlyRate = hourlyRate;
        DateHired = dateHired;
    }
}