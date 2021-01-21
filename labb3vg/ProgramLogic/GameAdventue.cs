using labb3vg.Enemies;
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
        bool winner, looser;
        static List<Monster> listOfMonstersOne = new List<Monster>();
        static List<Monster> listOfMonstersTwo = new List<Monster>();
        static List<Monster> listOfMonstersThree = new List<Monster>();

        public void Run()
        {
            CreateHero();
            CreateEnemies();

            int menyChoice = 0;
            while (!winner && !looser)
            { 
                PrintOptionMeny();
                Console.WriteLine("> ");
                menyChoice = Convert.ToInt32(Console.ReadLine());
                switch (menyChoice)
                {
                    case 1:
                        Adventurepicker();
                        break;
                    case 2:
                        hero.PrintStats(); // behöver jag göra en metod som har print stats i sig kanske för att få ut listan med items
                        break;
                    case 3:
                        Console.WriteLine("viva la boutiq");
                        Console.ReadLine();

                        break;
                    case 4:
                        Console.WriteLine("Bye!");
                        looser = true;
                        break;
                }

                if (winner)
                {
                    Console.WriteLine("u champ!");
                }




            }
            
        }

        public void CreateHero()
        {
            Console.WriteLine("\tWelcome adventurerer what is your name?");
            Console.WriteLine("\t(Cheat code == Robin)");
            hero.Name = Console.ReadLine();

            if(hero.Name == "Robin" || hero.Name == "robin")
            {
                hero.Attack = 1000;
                hero.MaxhP = 10000;
                hero.CurrentHp = 10000;
                hero.Armor = 500;
                hero.Experience = 0;
                hero.Level = 1;
                hero.Gold = 500;
                Console.WriteLine($" Welcome mighty {hero.Name} your power level is over 9000 and uou have so verry mutch armor att du inte kan dö!");
                Console.ReadLine();
            }

            else
            {
                hero.Attack = 5;
                hero.MaxhP = 30;
                hero.CurrentHp = 30;
                hero.Armor = 0;
                hero.Experience = 0;
                hero.Level = 1;
                hero.Gold = 10;
                Console.WriteLine($" Welcome mighty {hero.Name} your power level is over 9000 and your attack is {hero.Attack}");
                Console.ReadLine();
            }
        }

        public void CreateEnemies()
        {
            // Enkla Monster
            Cultist cultist = new Cultist();
            listOfMonstersOne.Add(cultist);

            //Mellanmjölk monster

            // Hell Monster
        }

        private void PrintOptionMeny()
        {
            Console.Clear();
            Console.WriteLine("\n\tThe night is dark and full off errors\n" +
                "1: Explore\n" +
                "2: Inventory/stats\n" +
                "3: Shop\n" +
                "4: Exit Game");
            // switch och val
            
        }
        private void Adventurepicker()
        {
           // Random rn = new Random();
           // int monsterRandomiser = rn.Next(listOfMonstersOne.Count);

            Console.Clear();
            Console.WriteLine("\n\tThe night is dark and full off errors\n" +
                "1: Lala Land\n" +
                "2: Mellanmjölk\n" +
                "3: Hell\n" +
                "4: Back to Main");
            int adventureChoice = default;
            adventureChoice = Convert.ToInt32(Console.ReadLine());
            
            switch (adventureChoice)
            {
                case 1:
                   
                    BattleLevelOne();
                    break;
                case 2:
                    BattleLevelTwo();
                    break;
                case 3:
                    BattleLevelThree();
                    break;
                case 4:                    
                    PrintOptionMeny();
                    break;
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Väljer en slumpmässigfiende som skickas vidare till battle comp eller 1 på 10 att man får en fördel
        /// </summary>
        private void BattleLevelOne()
        {
            Random rnDice = new Random();
            int luckDice = rnDice.Next(11);
            if (luckDice == 1)
            { 
                Console.WriteLine("lucky fudge!");
                Console.ReadLine();
            
            }
            else 
            { 
                Random rn = new Random();
                int monsterRandomiser = rn.Next(listOfMonstersOne.Count);
                BattleComp(listOfMonstersOne[monsterRandomiser]);
                
            }

            
        }
        private void BattleLevelTwo()
        {
            Random rn = new Random();
            int monsterRandomiser = rn.Next(listOfMonstersTwo.Count);
            Console.WriteLine("här blir det slagsmål");


            Console.ReadLine();
        }
        private void BattleLevelThree()
        {
            Random rn = new Random();
            int monsterRandomiser = rn.Next(listOfMonstersThree.Count);
            Console.WriteLine("här blir det slagsmål");


            Console.ReadLine();
        }
        private void BattleComp(Monster monster)
        {
            Console.WriteLine($"you hav encountered {monster.getName()}");         
            Console.ReadLine();
            while (!monster.isDead())
            {
                Console.WriteLine($"Du svingar och slår! {monster.getName()} tar {hero.GiveDmg(monster)} i skada");
                Console.WriteLine($"av {monster.getName()} kvarstår {monster.getHp()}");
                Console.ReadLine();
            }
        }
    }
}
