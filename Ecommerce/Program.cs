// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using Ecommerce.Model;

using static Ecommerce.Model.Product;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Dell", "xps 13\"", 9999.90f);
            User user = new User(1, "Adam", "Smith", "as@gmail.com", "password123");

            user.Phone = "999999999";

            Console.WriteLine(String.Format("{0:###-###-###}",Int32.Parse(user.Phone)));

        }
        
    }
}