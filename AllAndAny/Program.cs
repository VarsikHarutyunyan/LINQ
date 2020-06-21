using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AllAndAny
{
    class Program
    {
        static void Main(string[] args)
        {
            //All, Any and Contains  veradardznum en boolarjeq
            List<User> users = new List<User>()
                        {
                        new User { Name = "Tom", Age = 23 },
                        new User { Name = "Sam", Age = 43 },
                        new User { Name = "Bill", Age = 35 }
                        };

            //All
            //veradardznum e true ete bolor arjeqner@ bavararum en paymanin
            bool result1 = users.All(u => u.Age > 20); // true
            if (result1)
                Console.WriteLine("У всех пользователей возраст больше 20");
            else
                Console.WriteLine("Есть пользователи с возрастом меньше 20");

            bool result2 = users.All(u => u.Name.StartsWith("T")); //false
            if (result2)
                Console.WriteLine("У всех пользователей имя начинается с T");
            else
                Console.WriteLine("Не у всех пользователей имя начинается с T");

            //Any 
            //ete gone mek@ bavararum e paymanin veradardznum e true
            bool result3 = users.Any(u => u.Age < 20); //false
            if (result3)
                Console.WriteLine("Есть пользователи с возрастом меньше 20");
            else
                Console.WriteLine("У всех пользователей возраст больше 20");

            bool result4 = users.Any(u => u.Name.StartsWith("T")); //true
            if (result4)
                Console.WriteLine("Есть пользователи, у которых имя начинается с T");
            else
                Console.WriteLine("Отсутствуют пользователи, у которых имя начинается с T");
        }
    }
}
