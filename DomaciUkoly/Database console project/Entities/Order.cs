class Order{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int ReportID { get; set; }
    public bool HasArrived { get; set; }
    public float Price { get; set; }

    public Order(int id, string name, DateTime date, int reportID, bool hasArrived, float price)
    {
        Id = id;
        Name = name;
        Date = date;
        ReportID = reportID;
        HasArrived = hasArrived;
        Price = price;
    }

    public Order(string name, DateTime date, int reportID, bool hasArrived, float price)
    {
        Name = name;
        Date = date;
        ReportID = reportID;
        HasArrived = hasArrived;
        Price = price;
    }
}