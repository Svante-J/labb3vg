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
            Console.WriteLine("Welcome adventurerer what is your name?");
            hero.Name = Console.ReadLine();
            hero.Atack = 5;
            hero.MaxhP = 15;
            hero.CurrentHp = 15;
            hero.Armor = 0;
            hero.Experience = 0;
            hero.Level = 1;
            Console.WriteLine($" Welcome mighty {hero.Name} your power level is over 9000 and your atack is {hero.Atack}");            
        }

        private void OptionMeny()
        {
            Console.WriteLine("caman");
            // switch och val
            hero.Deskribe();
        }

        private void InspectHeroStats()
        {

            Console.WriteLine($"{hero.Name} ");
        }
    }
}
