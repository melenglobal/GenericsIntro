using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 20;

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Sandalye", UnitPrice = 120, UnitsInStock = 80 };
            // In real life productname  data etc. came from user input.

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
           






















        }
    }
}
