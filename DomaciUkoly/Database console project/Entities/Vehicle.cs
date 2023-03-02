class Vehicle
{
    public int Id { get; set; }
    public string Company { get; set; }
    public string Model { get; set; }
    public int YearOfManufacture { get; set; }
    public string Vin { get; set; }
    public int CustomerId { get; set; }

    public Vehicle(int id, string company, string model, int yearOfManufacture, string vin, int customerId)
    {
        Id = id;
        Company = company;
        Model = model;
        YearOfManufacture = yearOfManufacture;
        Vin = vin;
        CustomerId = customerId;
    }

    public Vehicle(string company, string model, int yearOfManufacture, string vin,int customerId)
    {
        Company = company;
        Model = model;
        YearOfManufacture = yearOfManufacture;
        Vin = vin;
        CustomerId = customerId;
    }
}