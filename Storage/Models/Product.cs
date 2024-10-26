namespace Storage.Models;

public class Product
{// auto properties
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Price { get; set; }
    public DateTime Orderdate { get; set; }
    public required string Category { get; set; }
    public required string Shelf { get; set; }
    public int Count { get; set; }
    public required string Description { get; set; }

    
}