using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How often do you here a drip of water?");
            string input_str = Console.ReadLine();
            double n = Convert.ToDouble(input_str);
            double hour = 3600 / n * 0.00025;
            double days = 86400 / n * 0.00025;
            double week = 604800 / n * 0.00025;
            Console.WriteLine("This wastes "+hour+" litres of water every hour");
            Console.WriteLine("This wastes "+days+" litres of water every day");
            Console.WriteLine("THis wastes "+week+" litres of water every week");
            Console.ReadLine();
        }
    }
}
