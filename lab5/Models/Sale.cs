using System.ComponentModel.DataAnnotations;

public class Sale
{
    public int SaleId { get; set; }
    [Required]
    public DateTime DateOfSale { get; set; }
    [Required]
    public decimal Quantity { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public decimal Discount { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public Product Product { get; set; }
    [Required]
    public int CompanyId { get; set; }
    [Required]
    public Company Company { get; set; }
}
