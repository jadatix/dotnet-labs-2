using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Product
{
    public ObjectId Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }

    [BsonElement("unitOfMeasurement")]
    public string UnitOfMeasurement { get; set; }
}
