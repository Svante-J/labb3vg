using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class Shaman : Monster
    {
        public Shaman()
        {
            base.AtkDmg = 5;
            base.Hp = 10;
            base.Level = 1;
            base.Name = "Shaman";
            base.Xp = 6;
            base.MaxHp = 10;
            base.GiveGold = 5;

        }

        public override int attack()
        {
            Console.WriteLine("\"come at me!\"");
            return base.attack();
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
