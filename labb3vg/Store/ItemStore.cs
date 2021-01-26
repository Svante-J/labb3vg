using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Store
{
    public class Item
    {
        private string name;
        private string description;
        private int boostValue;
        private int cost;

        public Item(string name, string description, int boostValue, int cost)
        {
            string Name = name;
            string Description = description;
            int BoostValue = boostValue;
            int Cost = cost;
        }
    }
}
