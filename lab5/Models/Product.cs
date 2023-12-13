using System.ComponentModel.DataAnnotations;

public class Product
{
    public int ProductId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string UnitOfMeasurement { get; set; }
}
