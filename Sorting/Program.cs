using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };

            var orderedNumbers = from item in numbers
                       orderby item
                       select item;

            var orderedNumbers2 = numbers.OrderBy(_=>_);

            foreach (int i in orderedNumbers)
                Console.WriteLine("number " + i);

            List<User> users = new List<User>()
{
    new User { Name = "Tom", Age = 33 },
    new User { Name = "Bob", Age = 30 },
    new User { Name = "Tom", Age = 21 },
    new User { Name = "Sam", Age = 43 }
};

            var orderUser = from user in users
                            orderby user.Name
                            select user;

            var orderUser2 = users.OrderBy(_=>_.Name);

            foreach (var item in orderUser2)
            {
                Console.WriteLine("Name " + item.Name);
            }


            var result = from user in users
                         orderby user.Name, user.Age
                         select user;

            var result2 = users.OrderBy(_ => _.Name).ThenBy(_=>_.Age);
            foreach (User u in result2)
                Console.WriteLine($"{u.Name} - {u.Age}");
        }
    }
}
