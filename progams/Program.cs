using System;

namespace SumeetApp26jun2023
{
    class Program
    { static void Main(string[] args)
        {
            int[] number = { 1, 2, 5, 4, 5 };
            foreach(int r in number)
            {
                Console.WriteLine(r);
            }
            string N = "Sumeet vishwakarma";
            string u = N.Insert(2, "sum");
            Console.WriteLine(u);
            string z = N.Remove(6, 7);
            Console.WriteLine(z);
            int i = N.IndexOf("t");
            Console.WriteLine(i);
        }
    }
}
