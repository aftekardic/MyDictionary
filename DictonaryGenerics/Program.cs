using System;
using System.Collections.Generic;

namespace DictonaryGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Kisiler = new Dictionary<int, string>();
            Kisiler.Add(0, "Ali Furkan");

            MyDictonary<int, string> Deneme = new MyDictonary<int, string>();
            Deneme.Add(2, "Mehmet");
            Console.WriteLine(Deneme);
        }
    }
}
