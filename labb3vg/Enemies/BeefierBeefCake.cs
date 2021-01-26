using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class BeefierBeefCake : Monster
    {
        public BeefierBeefCake()
        {
            base.AtkDmg = 16;
            base.Hp = 100;
            base.Level = 2;
            base.Name = "BeefierBeefCake";
            base.Xp = 40;
            base.MaxHp = 100;

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
