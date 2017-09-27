using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //simple example lambda expressions
            var filteredList = list.Where(x => x > 4);

            foreach (var item in filteredList) Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
