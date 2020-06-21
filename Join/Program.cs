using System;
using System.Collections.Generic;
using System.Linq;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
                            {
                                new Team { Name = "Bavarya", Country ="Germanya" },
                                new Team { Name = "Barselona", Country ="Ispanya" }
                            };

            List<Player> players = new List<Player>()
                            {
                                new Player {Name="Messi", Team="Barselona"},
                                new Player {Name="Neymar", Team="Barselona"},
                                new Player {Name="Robben", Team="Bavarya"}
                            };

            var result = from pl in players
                         join t in teams on pl.Team equals t.Name
                         select new { Name = pl.Name, Team = pl.Team, Country = t.Country };

            //Join @ ndunum e 4 argument arajin@ te vori het petq e join anenq
            //2 @st arajini vor propi-i
            //3 @st join linoxi vor prop-i
            //4 grvum e new ov nor veradardznvox arjeq@
            var result1 = players.Join(teams,
               p => p.Team,
               t => t.Name,
                (p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country });

            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");

            Console.WriteLine(new String('-', 30));
            //GroupJoin
            var result2 = teams.GroupJoin(
                        players, // второй набор
                        t => t.Name, // свойство-селектор объекта из первого набора
                        pl => pl.Team, // свойство-селектор объекта из второго набора
                        (team, pls) => new  // результирующий объект
                        {
                            Name = team.Name,
                            Country = team.Country,
                            Players = pls.Select(p => p.Name)
                        });

            foreach (var team in result2)
            {
                Console.WriteLine(team.Name);
                foreach (string player in team.Players)
                {
                    Console.WriteLine(player);
                }
                Console.WriteLine();
            }
        }
    }
}
