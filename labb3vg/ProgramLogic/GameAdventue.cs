﻿using labb3vg.Enemies;
using System;
using System.Collections.Generic;


namespace labb3vg.ProgramLogic
{
    /// <summary>
    /// All logig körs ifån 
    /// </summary>
    class GameAdventue
    {

        Hero hero = new Hero();
        static bool winner, looser;
        static List<Monster> listOfMonstersOne = new List<Monster>();
        static List<Monster> listOfMonstersTwo = new List<Monster>();
        static List<Monster> listOfMonstersThree = new List<Monster>();

        public void Run()
        {
            CreateHero();


            int menyChoice = 0;
            while (!winner && !looser)
            {
                CreateEnemies();
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
                    default:

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

            if (hero.Name.ToLower() == "robin")
            {
                hero.Attack = 1000;
                hero.MaxhP = 10000;
                hero.CurrentHp = 10000;
                hero.Armor = 500;
                hero.Experience = 0;
                hero.Level = 1;
                hero.Gold = 500;
                Console.WriteLine($" Welcome mighty {hero.Name} your power level is over 9000 and you have so verry mutch armor att du inte kan dö!");
                Console.Write(">");
                Console.ReadLine();
            }

            else
            {
                hero.Attack = 5;
                hero.MaxhP = 30;
                hero.CurrentHp = 30;
                hero.Armor = 1;
                hero.Experience = 0;
                hero.Level = 1;
                hero.Gold = 10;
                Console.WriteLine($" Welcome mighty {hero.Name} your attack is {hero.Attack}");
                Console.ReadLine();
            }
        }

        public void CreateEnemies()
        {

            // Enkla Monster
            Cultist cultist = new Cultist();
            BeefCake beefCake = new BeefCake();
            Shaman shaman = new Shaman();
            // Semi svåra Monster
            AngryCultist angryCultist = new AngryCultist();
            BeefierBeefCake beefierBeefCake = new BeefierBeefCake();
            CatHelmetShaman catHelmetShaman = new CatHelmetShaman();
            // Svåra
            DarkCultist darkCultist = new DarkCultist();
            BeefiestBeefCake beefiestBeefCake = new BeefiestBeefCake();
            DubbleCatHelmetShaman dubbleCatHelmetShaman = new DubbleCatHelmetShaman();

            listOfMonstersOne.Add(cultist);
            listOfMonstersOne.Add(beefCake);
            listOfMonstersOne.Add(shaman);
            listOfMonstersTwo.Add(angryCultist);
            listOfMonstersTwo.Add(beefierBeefCake);
            listOfMonstersTwo.Add(catHelmetShaman);
            listOfMonstersThree.Add(darkCultist);
            listOfMonstersThree.Add(beefiestBeefCake);
            listOfMonstersThree.Add(dubbleCatHelmetShaman);


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
                Console.WriteLine("its dangerous to go alone take this!");
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
            BattleComp(listOfMonstersTwo[monsterRandomiser]);
        }

        private void BattleLevelThree()
        {
            Random rn = new Random();
            int monsterRandomiser = rn.Next(listOfMonstersThree.Count);
            BattleComp(listOfMonstersThree[monsterRandomiser]); 
        }

        private void BattleComp(Monster localMonster)
        {
            localMonster.isDead();
            Console.WriteLine($"you hav encountered {localMonster.getName()}");
            Console.ReadLine();
            localMonster.isDead();// sätter tillbaka värdet på booolen om man redan slagits
            while (!localMonster.isDead())
            {
                Console.WriteLine($"Du svingar och slår! {localMonster.getName()} tar {hero.GiveDmg(localMonster)} i skada");
                Console.WriteLine($"av {localMonster.getName()} liv återstår {localMonster.getHp()}");

                if (localMonster.isDead())
                {
                    Console.WriteLine($"you have slain {localMonster.getName()} and gained {localMonster.getExp()}:Experiense and" +
                        $" {localMonster.DropGold()} gold");
                    hero.Experience = Utility.AddTwoNumbers(localMonster.getExp(), hero.Experience);
                    hero.Gold = Utility.AddTwoNumbers(localMonster.DropGold(), hero.Gold);
                    Console.WriteLine($"din xp är nu {hero.Experience} och du har {hero.Gold} i skattkistan");
                    Console.WriteLine($"Du har nu level {hero.GetMylevelVersion2(hero.Experience)}");
                    Console.ReadLine();
                    Console.Write(">");

                    if (hero.Level == 10)
                    {
                        Console.Clear();
                        Console.WriteLine("Congrats u have beaten the game");
                        Console.ReadLine();
                        winner = true;
                    }

                }
                else 
                {
                    // Räkna bort armor
                    int monsterDmg = Utility.SubbractTwoNumbers(localMonster.attack(),hero.Armor);                 
                    Console.WriteLine($"The skurk hit you for {monsterDmg}");
                    hero.TakeDamage(monsterDmg);
                    Console.WriteLine($"u has {hero.CurrentHp} left");
                    Console.ReadLine();
                
                }

                
                
            }
        }
    }
}
