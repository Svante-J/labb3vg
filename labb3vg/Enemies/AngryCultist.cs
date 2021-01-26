using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class AngryCultist : Monster
    {
        public AngryCultist()
        {
            base.AtkDmg = 9;
            base.Hp = 45;
            base.Level = 2;
            base.Name = "Angry Cultist";
            base.Xp = 45;
            base.MaxHp = 45;
            base.GiveGold = 5;

    }

        public override int attack()
        {
            Console.WriteLine("Hare hare hare");
            return base.attack();
        }
        public override int Loot()
        {
            return base.Loot();
        }
        public override string getName()
        {
            return base.getName();
        }

        public override bool isDead()
        {
            return base.isDead();
        }
        public override int getHp()
        {
            return base.getHp();
        }
        public override int getExp()
        {
            return base.getExp();
        }
    }
}

