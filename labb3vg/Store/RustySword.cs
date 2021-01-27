using System;
using System.Collections.Generic;
using System.Text;

namespace labb3vg.Store
{
    class RustySword : Item
    {
        public RustySword()
        { 
            base.Name = "Rusty Sword";
            base.Type = "weapon";
            base.Description = "Better than nothing";
            base.Boostvalue = 5;
            base.Cost = 15;
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
