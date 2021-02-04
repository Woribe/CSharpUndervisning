using System;

namespace Øvelse_5
{
    class Program
    {
        public static double Max(params double[] values)
        {
            double highest = double.MinValue;
            foreach (double item in values)
            {
                if(item > highest)
                {
                    highest = item;
                }
            }
            return highest;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Max(5.2, 6.0, 10.2, 1.1));
            Console.ReadKey();
        }
    }
}
