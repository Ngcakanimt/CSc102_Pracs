using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----Please enter an amount: ");
            string Amount = Console.ReadLine();
            double amount;
            bool amnt = double.TryParse(Amount, out amount);

            if (amnt && amount >= 0)
            {
                amount = Math.Round(amount, 2);

                while (amount > 0)
                {

                    if (amount >= 200)
                    {

                        double ans2 = amount / 200;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 200);
                        Console.WriteLine("Return {0} x R200 note<s>", ans2);
                        amount = Math.Round(amount, 2);

                    }
                    else if (amount >= 100)
                    {

                        double ans2 = amount / 100;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 100);
                        Console.WriteLine("Return {0} x R100 note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 50)
                    {

                        double ans2 = amount / 50;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 50);
                        Console.WriteLine("Return {0} x R50 note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 20)
                    {

                        double ans2 = (amount / 20);
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 20);
                        Console.WriteLine("Return {0} x R20 note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 10)
                    {

                        double ans2 = amount / 10;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 10);
                        Console.WriteLine("Return {0} x R10 note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 5)
                    {


                        double ans2 = amount / 5;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 5);
                        Console.WriteLine("Return {0} x 5 note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 2)
                    {

                        double ans2 = amount / 2;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 2);
                        Console.WriteLine("Return {0} x R2 note<s>", ans2);
                        amount = Math.Round(amount, 2);

                    }
                    else if (amount >= 1)
                    {

                        double ans2 = amount / 1;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 1);
                        Console.WriteLine("Return {0} x R1 note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 0.50)
                    {

                        double ans2 = amount / 0.50;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 0.50);
                        Console.WriteLine("Return {0} x 50c note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 0.20)
                    {

                        double ans2 = amount / 0.20;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 0.20);
                        Console.WriteLine("Return {0} x 20c note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 0.10)
                    {

                        double ans2 = amount / 0.10;
                        ans2 = Math.Floor(ans2);
                        amount = amount - (ans2 * 0.10);
                        Console.WriteLine("Return {0} x 10c note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                    else if (amount >= 0.05)
                    {


                        double ans2 = amount / 0.05;
                        amount = amount - 0.05;
                        ans2 = Math.Floor(ans2);
                        Console.WriteLine("Return {0} x 5c note<s>", ans2);
                        amount = Math.Round(amount, 2);

                    }
                    else if (amount >= 0.02)
                    {

                        double ans2 = amount / 0.02;
                        ans2 = Math.Floor(ans2);
                        amount = amount - 0.02;
                        Console.WriteLine("Return {0} x 2c note<s>", ans2);
                        amount = Math.Round(amount, 2);

                    }
                    else if (amount >= 0.01)
                    {
                        double ans2 = amount / 0.01;
                        ans2 = Math.Floor(ans2);
                        amount = amount - 0.01;
                        Console.WriteLine("Return {0} x 1c note<s>", ans2);
                        amount = Math.Round(amount, 2);
                    }
                }
                Console.WriteLine("please press ENTER to continue. . . . ");
                Console.ReadKey();
                Main(args);

            }
            else
            {
                Console.WriteLine("invalid number");
                Console.WriteLine("please press ENTER to continue. . . . ");
                Console.ReadKey();
                Main(args);
            }


        }
    }
}
