using System;
using System.Collections.Generic;

namespace TestProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = new string[6];
            int[] ints = { 5, 56 - 100, 18, 89 };

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(50);
            list.Add(13);
            list.Add(77);


            foreach (int item in list)
            {
                Console.WriteLine($"Dette element har værdien {item}");
            }
        }
    }
}
