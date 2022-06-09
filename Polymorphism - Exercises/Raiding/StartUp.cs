using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> raidList = new List<BaseHero>();
            int count = int.Parse(Console.ReadLine());
            int heroCount = 0;


            while (heroCount!=count)
            {

                string playerName = Console.ReadLine();
                string heroType = Console.ReadLine();
                if (heroType == nameof(Druid))
                {
                    raidList.Add(new Druid(playerName));
                    heroCount++;
                }
                else if (heroType == nameof(Paladin))
                {
                    raidList.Add(new Paladin(playerName));
                    heroCount++;
                }
                else if (heroType == nameof(Warrior))
                {
                    raidList.Add(new Warrior(playerName));
                    heroCount++;
                }
                else if (heroType == nameof(Rogue))
                {
                    raidList.Add(new Rogue(playerName));
                    heroCount++;
                }
                else
                {
                    Console.WriteLine($"Invalid Hero");
                }
            }
            long bossHealth = long.Parse(Console.ReadLine());

            foreach (var item in raidList)
            {
                Console.WriteLine($"{item.CastAbility()}");
                bossHealth -= item.Power;

            }
            if (bossHealth <= 0)
            {
                Console.WriteLine($"Victory!");
            }
            else
            {
                Console.WriteLine($"Defeat...");
            }

        }
    }
}
