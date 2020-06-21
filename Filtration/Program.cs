using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Filtration
{
    class Program
    {
        static void Main(string[] args)
        {
            //select all even elements that are greater than 10.
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            IEnumerable<int> evenEl = from item in numbers
                                      where item > 10 && item % 2 == 0
                                      select item;


            IEnumerable<int> evenEl2 = numbers.Where(x => x > 10 && x % 2 == 0);

            foreach (var item in evenEl2)
            {
                Console.WriteLine(item);
            }

            //we will choose those who are more than 25 years old

            List<User> users = new List<User> {
    new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
    new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
    new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
    new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}};

            var usersOld = from user in users
                           where user.Age > 23
                           select user;

            var usersOld2 = users.Where(_ => _.Age > 23);

            foreach (var item in usersOld)
            {
                Console.WriteLine("user = " + item.Name + " " + item.Age);
            }

            // old 25 and speake english

            var userEN = from user in users
                         from lang in user.Languages
                         where user.Age > 23 && lang == "английский"
                         select user;

            foreach (var item in userEN)
            {
                Console.WriteLine("user + lang = " + item.Name + " " + item.Age);
            }

        }

    }
}
