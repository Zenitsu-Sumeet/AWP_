using System;

namespace SumeetApp26jun2023
{class Program
    {
        delegate void sumeet(int x, int y);
        void Add(int x ,int y)
        {
            Console.WriteLine(x + y);
        }
      
        static void Main(string[] args)
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
            int ab = 10, bc = 78;
            int cd = Math.Min(ab, bc);
            int dc = Math.Max(ab, bc);
            Console.WriteLine(cd);
            Console.WriteLine(bc);
            Console.WriteLine("--------------------");
            if (ab > bc)
            {
                Console.WriteLine("Number is smaller");
            }
            else
            {
                Console.WriteLine("Number is Bigger");
            }
            Console.WriteLine(Math.Abs(-98));
            Console.WriteLine(Math.Pow(2, 6));
            Console.WriteLine(Math.Ceiling(12.54));
            Console.WriteLine(Math.Round(12.54));
            Console.WriteLine(Math.Floor(12.54));


            int[] array = new int[4] { 1, 2, 4, 5 };
            int[] cl = new int[array.Length];
            Array.Copy(array, cl, 3);
            Console.WriteLine("--------------------");

            Program p = new Program();
            p.Add(1, 4);
            sumeet d = new sumeet(p.Add);
            d(8, 5);
            


            Console.WriteLine("--------------------");










        }
    }
}
