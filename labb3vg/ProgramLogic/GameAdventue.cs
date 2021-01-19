using System;
using System.Collections.Generic;
using System.Text;


namespace labb3vg.ProgramLogic
{
    /// <summary>
    /// All logig körs ifån 
    /// </summary>
    class GameAdventue
    {
       
        Hero hero = new Hero();        

        public void Run()
        {
            
            CreateHero();

            OptionMeny();

            // gör en method adventure inventory/stats etc       Console.BackgroundColor = ConsoleColor.Red;       Console.ResetColor();
        }

        public void CreateHero()
        {
            Console.WriteLine("\tWelcome adventurerer what is your name?");
            Console.WriteLine("\t(Cheat code == Robin)");
            hero.Name = Console.ReadLine();

            if(hero.Name == "Robin" || hero.Name == "robin")
            {
                hero.Attack = 1000;
                hero.MaxhP = 15;
                hero.CurrentHp = 10000;
                hero.Armor = 500;
                hero.Experience = 0;
                hero.Level = 1;
                Console.WriteLine($" Welcome mighty {hero.Name} your power level is over 9000 and uou have so verry mutch armor att du inte kan dö!");
            }

            else
            {
                hero.Attack = 5;
                hero.MaxhP = 15;
                hero.CurrentHp = 15;
                hero.Armor = 0;
                hero.Experience = 0;
                hero.Level = 1;
                Console.WriteLine($" Welcome mighty {hero.Name} your power level is over 9000 and your atack is {hero.Attack}");
            }
        }

        private void OptionMeny()
        {
            Console.WriteLine("caman");
            // switch och val
            hero.PrintStats();
        }

        private void InspectHeroStats()
        {

            Console.WriteLine($"{hero.Name} ");
        }
    }
}
