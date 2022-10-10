using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214062
{
    internal class ProductTest_1214062
    {
        static void Main(string[] args)
        {
            /*Product_1214062 myProduct = new Product_1214062();

            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            Book_1214062 product1 = new Book_1214062("Book", "C# Object Oriented Solution", "100");
            DVD_1214062 product2 = new DVD_1214062("She's Hulk", "110");

            //Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} pages", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
