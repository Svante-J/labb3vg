using labb3vg.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg
{
    class Hero
    {
        private string name;
        private int maxHp;
        private int currentHp;
        private int attack;
        private int armor;
        private int level;
        private int experience;
        private int gold;

        private int[] levelingCurve = new int[] { 10, 25, 45, 80, 150, 250, 500, 1500, 2900, 6000 };
       
                      
        public Hero(string name, int maxhP, int currentHp, int atack, int armor, int level, int experience, int gold)
        {
            Name = name;
            MaxhP = maxhP;
            CurrentHp = currentHp;
            Attack = atack;
            Armor = armor;
            Level = level;
            Experience = experience;
            Gold = gold;
           // List<bool> HeroItems; // köper man i butik så gör vi dom true! lägg in alla items.
        }
       
        public Hero()
        {

        }

        public void Loot(Monster monster)
        {
            monster.DropGold();
            Gold += monster.DropGold();
        }
        
        public int GiveDmg(Monster monster)//input monster
        {
            monster.takeDamage(Attack);
            return Attack;
        }

        /*
        public int GetMylevel(int experince)//CHECK LEVEL
        {
            int Level = 0;
            //10, 25, 45, 80, 150, 250, 500, 1500, 2900, 6000
            if (experince < 10)
            {
                level = 1;
            }
            else if (experince >= 10 && experince < 22)
            {
                Level = 2;
            }
            return Level;
        } */

        public int GetMylevelVersion2(int experince)//CHECK LEVEL
        {
            int level = 1;
            foreach (var item in levelingCurve)
            {
                if (experince < item)
                { return level; }
                else
                {
                    level++;
                MaxhP *= 2;
                Attack *= 2;
                CurrentHp = MaxhP;
                Level = level;
                    if (MaxhP > 5000)
                    { MaxhP = 5000; Attack = 600; }
                }


            }
            return level;

        }

        public void TakeDamage(int monsterdmg)
        {
            CurrentHp -= monsterdmg;
        }

        public void PrintStats()
        {
            Console.WriteLine($"\tMighty {Name}\nLevel:{Level}\nExperience:{Experience}\nHP:{CurrentHp}/{MaxhP}\nAttack:{Attack}\nArmor:{Armor}\nGold:{Gold}");
            Console.WriteLine("\nPLAYER INVENTORY");
            Console.WriteLine("================");
            Console.WriteLine("You have zero items");
            Console.ReadLine();
        }

        public string Name { get => name; set => name = value; }
        public int MaxhP { get => maxHp; set => maxHp = value; }
        public int CurrentHp { get => currentHp; set => currentHp = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Armor { get => armor; set => armor = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Gold { get => gold; set => gold = value; }
    }
    

}
