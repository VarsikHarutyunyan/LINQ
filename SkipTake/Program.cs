using System;
using System.Linq;

namespace SkipTake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };
            string[] teams = { "Bavaria", "Borsia", "Real Madrid", "Manchestr City", "Barselona" };

            Console.Write("Numbers");
            foreach (var item in numbers)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Console.Write("teams");
            foreach (var item in teams)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            //Take
            //Take veradardznum e tarrer ays depqum 3 hat,
            //Take ogtagorcum enq mer uzac qanakov  veradardznelu hamar

            var resultTake = numbers.Take(3);

            Console.Write("Take");
            foreach (int i in resultTake)
                Console.Write("  " + i);
                Console.WriteLine();
            //Skip
            //Skip bac e toxnum  tarrer 3 hat,
            //Skip ogtagorcum enq mer uzac qanakov tarrer bac toxnelu  hamar

            var resultSkip = numbers.Skip(3);

            Console.Write("Skip");
            foreach (int i in resultSkip)
                Console.Write("  " + i);
            Console.WriteLine();

            //Skip Take
            Console.WriteLine("Skip 4, Take 2");
            var result = numbers.Skip(4).Take(2);

            foreach (int i in result)
                Console.Write(" " + i);
            Console.WriteLine();

            // Take Skip
            //verdznum e 4 hat heto skzbi 2 skip e anum veradardznum verjin 2@
            Console.WriteLine("Take 4,Skip 2");
          
            var result1 = numbers.Take(4).Skip(2);
            foreach (int i in result1)
                Console.Write(" " + i);
            Console.WriteLine();

            //TakeWhile
            //@ntrum e tarrer voronq bavararum en paymani 
            //bayc ete payman@ xaxtvec aylevs chi nayum  payymanin 
            //ete orinak B chsksi mer zangvaci araji andam@ kveradardzni 0 u myusnerin chi nayi

            Console.WriteLine("TakeWhile");
              foreach (var t in teams.TakeWhile(x => x.StartsWith("B")))
                Console.Write(" " + t);
            Console.WriteLine();

            //SkipWhile
            //bac e toxum tarrer voronq bavararum en paymani 
            //bayc ete payman@ xaxtvec aylevs chi nayum  payymanin 
            //ete orinak B chsksi mer zangvaci araji andam@ kveradardzni myusnerin 

            Console.WriteLine("SkipWhile");
            foreach (var t in teams.SkipWhile(x => x.StartsWith("B")))
                Console.Write(" " + t);
            Console.WriteLine();
        }
    }
}
