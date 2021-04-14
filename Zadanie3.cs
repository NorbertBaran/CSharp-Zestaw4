using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cw4
{
    public class Zadanie3
    {
        public static void Main3(string[] args)
        {
            var line = "";
            List<string> cities = new List<string>();

            while (line != "X")
                cities.Add(line = Console.ReadLine());

            var cites =
                from city in cities
                group city by city[0]
                into cityGroup
                orderby cities
                select cityGroup;

            while (true)
            {
                var c = Console.ReadLine()[0];
                try {
                    cites.First(x => x.Key == c).ToList().ForEach(city => Console.Write(city + ", "));
                    Console.WriteLine();
                }
                catch (Exception e){
                    Console.WriteLine("PUSTE");
                }
            }
        }
    }
}