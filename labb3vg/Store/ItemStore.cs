using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Store
{
   abstract class Item
    {
        private string name;
        private string description;
        private int boostValue;
        private int cost;

        public virtual int Sell()
        {
            return this.cost;
        }



        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Boostvalue { get => boostValue; set => boostValue = value; }
        public int Cost { get => cost; set => cost = value; }
    }
}
