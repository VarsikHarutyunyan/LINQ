using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>
                        {
                        new Phone {Name="Lumia 430", Company="Microsoft" },
                        new Phone {Name="Mi 5", Company="Xiaomi" },
                        new Phone {Name="LG G 3", Company="LG" },
                        new Phone {Name="iPhone 5", Company="Apple" },
                        new Phone {Name="Lumia 930", Company="Microsoft" },
                        new Phone {Name="iPhone 6", Company="Apple" },
                        new Phone {Name="Lumia 630", Company="Microsoft" },
                        new Phone {Name="LG G 4", Company="LG" }
                        };

            var phoneGroup = from phone in phones
                             group phone by phone.Company;

            foreach (IGrouping<string, Phone> item in phoneGroup)
            {
                Console.WriteLine("Company = " + item.Key);
                foreach (var name in item)
                {
                    Console.WriteLine(name.Name);
                }
            }

            Console.WriteLine(new String('-', 30));

            var phoneGropu1 = phones.GroupBy(_=>_.Company);

            foreach (IGrouping<string, Phone> item in phoneGropu1)
            {
                Console.WriteLine("Company = " + item.Key);
                foreach (var name in item)
                {
                    Console.WriteLine(name.Name);
                }
            }

            Console.WriteLine(new String('-', 30));
            //Group bay Company and return key and count

            var newGroup = from phone in phones
                           group phone by phone.Company into g //into mijocov pahum enq mer havagacun
                           select new                           // ev karoxanum enq nor objec sargel
                           {
                               Key = g.Key,
                               Count = g.Count()
                           };

            foreach (var group in newGroup)
                Console.WriteLine($"{group.Key} : {group.Count}");

            var newGroup1 = phones.GroupBy(p => p.Company)
                        .Select(g => new { Key = g.Key, Count = g.Count() });

        }
    }
}
