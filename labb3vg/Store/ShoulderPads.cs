using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Store
{
    class ShoulderPads : Item
    {
        public ShoulderPads()
        {
            base.Name = "Shoulder Pads";
            base.Type = "Armor";
            base.Description = "80 talet var tog du vägen?";
            base.Boostvalue = 5;
            base.Cost = 50;
            base.Equiped = false;
        }
        public override int Sell()
        {
            return base.Sell();
        }
        public override bool Sold()
        {
            return base.Sold();
        }
    }
}
