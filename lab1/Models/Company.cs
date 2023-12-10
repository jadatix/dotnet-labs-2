using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Company
{
    public ObjectId Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("legalAddress")]
    public string LegalAddress { get; set; }

    [BsonElement("contactPhone")]
    public string ContactPhone { get; set; }

    [BsonElement("managers")]
    public List<Manager> Managers { get; set; }
}
