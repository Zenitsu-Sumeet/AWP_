using System;
using System.Collections;
namespace SumeetApp26jun2023
{
    class array
    {
         static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(12);
            a.Add(155);
            a.Add("sumeet");
            foreach(object i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
