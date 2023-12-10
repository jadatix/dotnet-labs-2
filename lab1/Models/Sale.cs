public class Sale
{
    public int SaleId { get; set; }
    public DateTime DateOfSale { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
}
