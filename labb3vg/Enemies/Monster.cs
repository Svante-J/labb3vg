using System;

namespace labb3vg.Enemies
{
    abstract class Monster
    {
        private string name;
        private int level;
        private int xp;
        private int hp;
        private int maxHp;
        private int giveGold;
        private int atkDmg;
        private bool dead;

        Random rn = new Random();

        public Monster()
        {

        }


        public virtual int Loot()
        {
            rn.Next(giveGold);
            return giveGold;
        }

        public virtual int attack()
        {
            rn.Next(atkDmg);
            return atkDmg;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public virtual int getExp()
        {
            return this.xp;
        }
        public virtual int getHp()
        {
            return this.hp;
        }
        public virtual bool isDead()
        {
            if (this.hp <= 0)
            {
                this.dead = true;
            }
            else
            {
                this.dead = false;
            }

            return this.dead;


        }

        public virtual void takeDamage(int damage)
        {
            this.hp -= damage;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Xp { get => xp; set => xp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int GiveGold { get => giveGold; set => giveGold = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }
        public bool Dead { get => dead; set => Dead = value; }
    }
}
