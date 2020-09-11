using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: WarriorWater.cs
* Purpose: Class representing data for the Warrior Water menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Warrior Water
    /// </summary>
    public class WarriorWater : Drink
    {
        /// <summary>
        /// Gets the price of the water
        /// </summary>
        public override double Price => 0.0;

        /// <summary>
        /// Gets the calories of the water
        /// </summary>
        public override uint Calories => 0;

        /// <summary>
        /// Stores true if this drink should be served with ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Stores true if this drink should be served with a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Returns a list of special instructions for this drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                    instructions.Add("Hold ice");
                if (Lemon)
                    instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Creates a string representation of this drink
        /// </summary>
        /// <returns>A string with the format "[Size] Warrior Water"</returns>
        public override string ToString()
        {
            return string.Format("{0} Warrior Water", Size.ToString());
        }
    }
}
