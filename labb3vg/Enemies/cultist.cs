using System;

namespace labb3vg.Enemies
{
    class Cultist : Monster
    {

        public Cultist()
        {
            base.AtkDmg = 3;
            base.Hp = 15;
            base.Level = 1;
            base.Name = "Cultist";
            base.Xp = 5;
            base.MaxHp = 15;
            base.GiveGold = 5;
            base.GiveGold = 5;


        }
        public override int DropGold()
        {
            return base.DropGold();
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
