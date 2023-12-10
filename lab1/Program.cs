using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new TradeContext())
        {
            var sales = context.Sales
                .Include(s => s.Product)
                .Include(s => s.Company)
                .ToList();

            foreach (var sale in sales)
            {
                Console.WriteLine($"Company: {sale.Company.Name}, Product: {sale.Product.Name}, Date of Sale: {sale.DateOfSale}");
            }
        }
    }
}
