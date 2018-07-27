using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your monthly salary: ");
            string input_salary = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string input_age = Console.ReadLine();
            int salary = Convert.ToInt32(input_salary);
            int age = Convert.ToInt32(input_age);

            if (salary > 0 && age > 0)
                if (salary >= 0 && salary <= 4999)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 0");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 0");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 0");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }

                else if (salary >= 5000 && salary <= 6499)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 13");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 0");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 0");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");

                }

                else if (salary >= 6500 && salary <= 7799)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 250");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 0");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 0");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }

                else if (salary >= 7800 && salary <= 9999)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 620");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 0");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 0");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }
                else if (salary >= 10000 && salary <= 13499)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 1200");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 600");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 400");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }
                else if (salary >= 13500 && salary <= 17899)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 2100");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 1500");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 1200");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }
                else if (salary >= 17900 && salary <= 19999)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 2700");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 2000");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 1800");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }
                else if (salary >= 20000 && salary <= 39999)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 8000");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 7500");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 7300");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }
                else if (salary >= 40000 && salary <= 59999)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 16000");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 15600");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 15400");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");
                }
                else if (salary >= 60000)
                {
                    if (age < 65)
                        Console.WriteLine("Your monthly tax is 20000");
                    if (age >= 65 && age < 75)
                        Console.WriteLine("Your monthly tax is 17050");
                    if (age > 75)
                        Console.WriteLine("Your monthly tax is 17000");
                    Console.ReadLine();
                    Console.WriteLine("Press ENTER to continue...");

                }





                    
















                }
        }
    }   
