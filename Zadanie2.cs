using System;
using System.Linq;

namespace Cw4
{
    public class Zadanie2
    {
        public static void Main2(string[] args)
        {
            Console.WriteLine("Type N: ");
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine("Type M: ");
            var M = int.Parse(Console.ReadLine());

            var rowEnum =
                from num in Enumerable.Range(0, M)
                select new Random().Next(-100, 100);

            var matrixEnum =
                from num in Enumerable.Range(0, N)
                select rowEnum;

            var matrixSum = matrixEnum.SelectMany(row => row).ToList().Sum();

            Console.WriteLine("Sum: {0}", matrixSum);
        }
    }
}