using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class DubbleCatHelmetShaman : Monster
    {
        public DubbleCatHelmetShaman()
        {
            base.AtkDmg = 400;
            base.Hp = 1500;
            base.Level = 3;
            base.Name = "Shaman with two cat helmets";
            base.Xp = 1200;
            base.MaxHp = 1500;

        }

        public override int attack()
        {
            Console.WriteLine("Mjau!");
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
