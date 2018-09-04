using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    class Cart
    {
        public void Add(List<Product> AllProductsObject, int id , List<Product> CartData, int Quantity) //Product Added to Cart
        {
            if (AllProductsObject[id].Quantity >= Quantity)
            {
                CartData.Add(AllProductsObject[id]);
                AllProducts product = new AllProducts();
                product.UpdateQuantity(id, AllProductsObject);
                Console.WriteLine("Product Added Successfully");
            }
        }
        public void DisplayCart(List<Product> CartData)
        {
            if (CartData.Count > 0)
            {
                CartData.ForEach(item => Console.WriteLine("ID: " + item.ProductId + " Name: " + item.ProductName + " Price: " + item.ProductPrice));
            }
            else
            {
                Console.WriteLine("Cart is Empty");
            }
        }
        public void ClearCart(List<Product> CartData)
        {
            CartData.Clear();
            Console.WriteLine("Cart is Clear Successfully");
        }
        public void RemoveParticularProductFromCart(List<Product> CartData, int id)
        {
            var found = CartData.Find(item => item.ProductId == id);
            if (found != null) CartData.Remove(found); Console.WriteLine(found.ProductName + "is Successfully Removed ");
        }
        public void TotalAmountOfCart(List<Product> CartData)
        {
            decimal Total = 0;
            CartData.ForEach(item => Total += item.ProductPrice);
            Console.WriteLine("Total Amount: " + Total);
        }
    }
}
