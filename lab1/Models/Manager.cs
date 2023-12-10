using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Manager
{
    public ObjectId Id { get; set; }

    [BsonElement("surname")]
    public string Surname { get; set; }

    [BsonElement("firstName")]
    public string FirstName { get; set; }

    [BsonElement("patronymic")]
    public string Patronymic { get; set; }
}
