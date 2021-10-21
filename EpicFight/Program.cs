using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            hero = RandomHero();
            heroWeapon = RandomWeapon();
            villain = RandomVillain();
            villainWeapon = RandomWeapon();
            
            Console.WriteLine($"{hero} will fight {villain}.");
            Console.WriteLine ($"{hero} will fight {heroweapon}")
        }
    

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }



        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patric", "Laura Croft" };
            
            int randomIndex = rnd.Next(0, heroes.Length);

            string randomHero = heroes[randomIndex];
            return randomHero;
        }
    
        private static string RandomVillain()
        {
            string[] villains = { "Joker", "Darth Vader", "Thanos", "Loki", "T-1000" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);

            string randomVillain = villains[randomIndex];
            return randomVillain;
        }
    
      private static string RandomWeapon()
        {

        }
    
    }
}
