using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0; int num2 = 0;

            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Devide");
            Console.WriteLine("Your option?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = {num1 + num2}");
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = {num1 - num2}");
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = {num1*num2}");
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = {num1/num2}");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine("Press any key to close the calculator console");
            Console.ReadKey();

        }
    }
}
