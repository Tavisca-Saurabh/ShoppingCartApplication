using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> AllProducts = new List<Product>();
            AllProducts products = new AllProducts();
            products.AddProduct(AllProducts);
            List<Product> CartData = new List<Product>();
            Cart obj = new Cart();
            while (true)
            {
                Console.WriteLine("||--Welcome to E-Commerce Website--||");
                Console.WriteLine("Enter Option");
                Console.WriteLine("1) Show Product" +
                                "\n2) Show Cart" +
                                "\n3) Remove Particular Item in Cart" +
                                "\n4) Total Amount of Cart" +
                                "\n5) Clear Cart" +
                                "\n6) Exit");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        {
                            Console.Clear();
                            products.DisplayAllProducts(AllProducts);
                            Console.WriteLine("Enter Product ID You want to add to cart");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Product Quantity You want to add to cart");
                            int Quantity = Convert.ToInt32(Console.ReadLine());
                            obj.Add(AllProducts, id, CartData,Quantity);
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            obj.DisplayCart(CartData);
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            obj.DisplayCart(CartData);
                            Console.WriteLine("Enter Product ID You want to Remove From Cart: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            obj.RemoveParticularProductFromCart(CartData, id);
                            obj.DisplayCart(CartData);
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            obj.TotalAmountOfCart(CartData);
                            Console.WriteLine();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            obj.ClearCart(CartData);
                            Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
