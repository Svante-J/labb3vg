namespace labb3vg.ProgramLogic
{
    static class Utility
    {
        /// <summary>
        /// Används för xp returnering
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// skulle även kunna heta SubtractArmor
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int SubbractTwoNumbers(int monsterAttack, int armor)
        {
            monsterAttack -= armor;
            if (monsterAttack < 0)
            {
                monsterAttack = 0;
                return monsterAttack;
            }
            else
            {
                return monsterAttack;
            }
            
        }





        /*
       
        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));           
        }


         public void Batlle()
         Utility levelingCurve()
        */
    }
}
