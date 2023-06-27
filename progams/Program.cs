using System;

namespace SumeetApp26jun2023
{class Program
    { static void Main(string[] args)
        {
            int[] number = { 1, 2, 5, 4, 5 };
            foreach(int r in number)
            {   Console.WriteLine(r);
            }
            string N = "Sumeet vishwakarma";
            string me = " coder";
            Console.WriteLine("--------------------");
            string u = N.Insert(2, "sum");
            Console.WriteLine(u);
            Console.WriteLine("--------------------");
            string z = N.Remove(6, 7);
            Console.WriteLine(z);
            Console.WriteLine("--------------------");
            int i = N.IndexOf("t");
            Console.WriteLine(i);
            Console.WriteLine("--------------------");
            int l = N.LastIndexOf("a");
            Console.WriteLine(l);
            Console.WriteLine("--------------------");
            string c = String.Concat(N, me);
            Console.WriteLine(c);
            Console.WriteLine("--------------------");
            string a = "coder";
            string b = "coder";
            bool answer = string.Equals(a, b);
            Console.WriteLine(answer);
            Console.WriteLine("--------------------");
            String he = "hello World";
            bool t = he.Contains("wo");
            Console.WriteLine(t);
            Console.WriteLine("--------------------");

            string here = "how is you";
            bool come = here.StartsWith("how");
            Console.WriteLine(come);
            Console.WriteLine("--------------------");

            bool end = here.EndsWith("you");
            Console.WriteLine(end);
            Console.WriteLine("--------------------");

        }
    }
}
