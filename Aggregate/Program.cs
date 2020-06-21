using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            List<User> users = new List<User>()
                            {
                                new User { Name = "Tom", Age = 23 },
                                new User { Name = "Sam", Age = 43 },
                                new User { Name = "Bill", Age = 35 }
                            };

            //Aggregate 
            //arajin andamin - erkrord@ ardyunqic 3-rd @ ev ayspes sharunak
            int query = numbers.Aggregate((x, y) => x - y); // 1 - 2 - 3 - 4 - 5
            Console.WriteLine(query);
            int queryAdd = numbers.Aggregate((x, y) => x + y); // аналогично 1 + 2 + 3 + 4 + 5
            Console.WriteLine(queryAdd);
            //Count
            //veradardznum e qanak@

            int size = (from i in numbers where i % 2 == 0 && i > 10 select i).Count();
            Console.WriteLine(size);

            int size2 = numbers.Count(i => i % 2 == 0 && i > 10);
            Console.WriteLine(size2);

            //Sum

            //numbers sum

            var numbersSum = numbers.Sum();
            Console.WriteLine("numbersSum " + numbersSum);

            //sum user age
            var UserAgeUsum = users.Sum(_ => _.Age);
            Console.WriteLine("UserAgeUsum " + UserAgeUsum);

            //Min

            //min numbers
            var minNumbers = numbers.Min();
            Console.WriteLine("minNumbers " + minNumbers);
            //min user age
            var minAge = users.Min(_ => _.Age);
            Console.WriteLine("minAge " + minAge);

            //max

            //min numbers
            var maxNumbers = numbers.Max();
            Console.WriteLine("maxNumbers " + maxNumbers);
            //min user age
            var maxAge = users.Max(_ => _.Age);
            Console.WriteLine("maxAge " + maxAge);

            //Average
            //bolor@ gumarum e irar bajanum qanaki

            //numbers Average
            double avrNumber = numbers.Average();
            Console.WriteLine("avrNumber " + avrNumber);

            //user age Average
            double avrUser = users.Average(n => n.Age);
            Console.WriteLine("avrUser " + avrUser);
        }
    }
}
