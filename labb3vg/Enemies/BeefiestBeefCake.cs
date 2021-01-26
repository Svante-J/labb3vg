using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class BeefiestBeefCake : Monster
    {
        public BeefiestBeefCake()
        {
            base.AtkDmg = 60;
            base.Hp = 1000;
            base.Level = 3;
            base.Name = "BeefierBeefCake";
            base.Xp = 1000;
            base.MaxHp = 1000;

        }

        public override int attack()
        {
            Console.WriteLine("\"All your bases are beloning to us!\"");
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
