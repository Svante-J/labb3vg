using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Store
{
   abstract class Item
    {
        private string name;
        private string type;
        private string description;
        private int boostValue;
        private int cost;
        private bool equiped;

        // Ger pris när item säljes
        public virtual int Sell()
        {
            return this.cost;
        }
        public virtual bool Sold()
        {
            this.equiped = true;
            return this.equiped;
        }




        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public int Boostvalue { get => boostValue; set => boostValue = value; }
        public int Cost { get => cost; set => cost = value; }
        public bool Equiped { get => equiped; set => equiped = value; }
    }
}
