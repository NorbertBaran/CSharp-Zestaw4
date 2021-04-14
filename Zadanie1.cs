using System;
using System.Collections.Generic;
using System.Linq;

namespace Cw4
{
    class Zadanie1
    {
        public static void Main1(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var query =
                from num in Enumerable.Range(1, N)
                where num != 5 && num != 9 && (num % 2 == 1 || num % 7 == 0)
                select num * num;

            Console.WriteLine("Sum: {0}", query.Sum());
            Console.WriteLine("Count: {0}", query.Count());
            Console.WriteLine("First: {0}", query.First());
            Console.WriteLine("Last: {0}", query.Last());
            try{
                Console.WriteLine("Third: {0}", query.ElementAt(2));
            }catch(Exception e){
                Console.WriteLine("Third: Not exist");
            }
        }
    }
}