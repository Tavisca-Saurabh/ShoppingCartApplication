using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    class AllProducts
    {
        public void AddProduct(List<Product> AllProductsObject)
        {
            AllProductsObject.Add(new Product { ProductId = 0, ProductName = "Abc", ProductPrice = 30 , Quantity=5});
            AllProductsObject.Add(new Product { ProductId = 1, ProductName = "Def", ProductPrice = 40, Quantity = 10});
        }
        public void DisplayAllProducts(List<Product> AllProductsObject)
        {
            AllProductsObject.ForEach(item => Console.WriteLine("ID: " + item.ProductId + " Name: " + item.ProductName + " Price: " + item.ProductPrice));
        }
        public void UpdateQuantity(int id, List<Product> AllProductsObject)
        {
            //Update Quantity
        }
    }
}
