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
        private int atack;
        private int armor;
        private int level;
        private int experience;
        private int gold;

        public Hero(string name, int maxhP, int currentHp, int atack, int armor, int level, int experience, int gold)
        {
            Name = name;
            MaxhP = maxhP;
            CurrentHp = currentHp;
            Atack = atack;
            Armor = armor;
            Level = level;
            Experience = experience;
            Gold = gold;
        }
        public Hero()
        {

        }
        public void Deskribe()
        {
            Console.WriteLine(Name + MaxhP + Armor);
        }

        public string Name { get => name; set => name = value; }
        public int MaxhP { get => maxHp; set => maxHp = value; }
        public int CurrentHp { get => currentHp; set => currentHp = value; }
        public int Atack { get => atack; set => atack = value; }
        public int Armor { get => armor; set => armor = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Gold { get => gold; set => gold = value; }
    }
    

}
