using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class CatHelmetShaman : Monster
    {
        public CatHelmetShaman()
        {
            base.AtkDmg = 20;
            base.Hp = 30;
            base.Level = 2;
            base.Name = "Shaman with cat helmet";
            base.Xp = 35;
            base.MaxHp = 30;
            base.GiveGold = 50;

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
