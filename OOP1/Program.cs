using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Makas";
            product1.UnitPrice = 400;
            product1.UnitsInStock = 12;

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Kalem", UnitsInStock = 8, UnitPrice = 56 };

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

          
        }
    }
}
