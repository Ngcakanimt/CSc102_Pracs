using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wholeglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many litres do you use?");
            string user = Console.ReadLine();
            double conv = Convert.ToDouble(user);
            double n = conv * 1000 / 250;
            Console.WriteLine("You use " + n + " glasses of water");
            Console.ReadLine();
        }
    }
}
