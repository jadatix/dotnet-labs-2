db = db.getSiblingDB('TradesOperations');

db.companies.insertOne({
    name: "Company1",
    legalAddress: "Address1",
    contactPhone: "1234567890",
    managers: [{
        surname: "Smith",
        firstName: "John",
        patronymic: "A."
    }]
});

db.companies.insertOne({
    name: "Company2",
    legalAddress: "Address2",
    contactPhone: "1234567891",
    managers: []
});

db.products.insertOne({
    name: "Product1",
    description: "Description1",
    unitOfMeasurement: "Unit1"
});

db.sales.insertOne({
    dateOfSale: new Date("2023-01-01T00:00:00Z"),
    quantity: 10,
    price: 100,
    discount: 5,
    product: {
        name: "Product1",
        description: "Description1",
        unitOfMeasurement: "Unit1"
    },
    company: {
        name: "Company1",
        legalAddress: "Address1",
        contactPhone: "1234567890"
    }
});
