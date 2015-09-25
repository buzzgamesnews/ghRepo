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

<<<<<<< HEAD
            Console.Write("This is test branch");

=======
            Console.Write("123---asd");
            Console.Write("321===asd");
>>>>>>> 3fdc1ef... Merge branch 'Feature/Conflict'

            Console.ReadKey();
        }

        static void GoodBuy()
        {
            Console.WriteLine("goodBuy!");
        }
    }
}
