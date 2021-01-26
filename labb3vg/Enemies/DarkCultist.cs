using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class DarkCultist : Monster
    {
        public DarkCultist()
        {
            base.AtkDmg = 250;
            base.Hp = 490;
            base.Level = 3;
            base.Name = "Dark Cultist";
            base.Xp = 600;
            base.MaxHp = 490;

        }

        public override int attack()
        {
            Console.WriteLine("Hare hare hare");
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
