using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models;

public class Product
{// auto properties
    public int Id { get; set; }


    [StringLength(8)] 
    public required string Name { get; set; }


    [Range(1, 100, ErrorMessage = "Price must be between 1 and 100")]
    public int Price { get; set; }


    [DataType(DataType.Date)]
    public DateTime Orderdate { get; set; }


    [StringLength(6)]
    public required string Category { get; set; }


    [StringLength(5)]
    public required string Shelf { get; set; }


    [DisplayName("Quantity"), Range(0, 15, ErrorMessage = "Quantity must be between 0 and 15")]
    public int Count { get; set; }
    

    [StringLength(10)]
    public required string Description { get; set; }
}