using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Sale
{
    public ObjectId Id { get; set; }

    [BsonElement("dateOfSale")]
    public DateTime DateOfSale { get; set; }

    [BsonElement("quantity")]
    public decimal Quantity { get; set; }

    [BsonElement("price")]
    public decimal Price { get; set; }

    [BsonElement("discount")]
    public decimal Discount { get; set; }

    [BsonElement("product")]
    public Product Product { get; set; }

    [BsonElement("company")]
    public Company Company { get; set; }
}
