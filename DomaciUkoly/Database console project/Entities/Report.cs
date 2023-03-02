class Report
{
    public int Id { get; set;}
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public int CustomerId { get; set; }
    public int VehicleId { get; set; }
    public int TechnicianId { get; set; }

    public Report(int id, DateTime date, string description, float price, int customerId, int vehicleId, int technicianId)
    {
        Id = id;
        Date = date;
        Description = description;
        Price = price;
        CustomerId = customerId;
        VehicleId = vehicleId;
        TechnicianId = technicianId;
    }

    public Report(DateTime date, string description, float price, int customerId, int vehicleId, int technicianId)
    {
        Date = date;
        Description = description;
        Price = price;
        CustomerId = customerId;
        VehicleId = vehicleId;
        TechnicianId = technicianId;
    }
}