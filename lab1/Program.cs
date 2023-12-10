using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapGet("/sales", async (HttpContext httpContext) =>
{
    var client = new MongoClient("mongodb://rootuser:rootpass@localhost:27017");
    var database = client.GetDatabase("TradesOperations");
    var salesCollection = database.GetCollection<Sale>("sales");

    var sales = await salesCollection.Find(_ => true).ToListAsync();

    var options = new JsonSerializerOptions { WriteIndented = true };
    var jsonResponse = JsonSerializer.Serialize(sales, options);

    return Results.Ok(jsonResponse);
});

app.MapGet("/logo", async (HttpContext httpContext) =>
{
    httpContext.Response.ContentType = "image/png";
    await httpContext.Response.SendFileAsync("patron.jpg");
});

app.Run();
