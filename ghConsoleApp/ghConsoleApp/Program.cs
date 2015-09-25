using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Change master branch!");
            GoodBuy();

            Console.Write("This is test branch");


            Console.ReadKey();
        }

        static void GoodBuy()
        {
            Console.WriteLine("goodBuy!");
        }
    }
}
