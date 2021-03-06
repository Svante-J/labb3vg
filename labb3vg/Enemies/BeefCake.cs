﻿using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Enemies
{
    class BeefCake : Monster
    {
        public BeefCake()
        {
            base.AtkDmg = 4;
            base.Hp = 25;
            base.Level = 1;
            base.Name = "BeefCake";
            base.Xp = 8;
            base.MaxHp = 15;
            base.GiveGold = 5;

        }

        public override int attack()
        {
            Console.WriteLine("BraAAAAAWL");
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
