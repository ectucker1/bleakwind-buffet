using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: MarkarthMilk.cs
* Purpose: Class representing data for the Markarth Milk menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.22;
                    case Size.Medium:
                        return 1.11;
                    case Size.Small:
                    default:
                        return 1.05;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 93;
                    case Size.Medium:
                        return 72;
                    case Size.Small:
                    default:
                        return 56;
                }
            }
        }

        /// <summary>
        /// Stores true if this drink should be served with ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Returns a list of special instructions for this drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                    instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Creates a string representation of this drink
        /// </summary>
        /// <returns>A string with the format "[Size] Markarth Milk"</returns>
        public override string ToString()
        {
            return string.Format("{0} Markarth Milk", Size.ToString());
        }
    }
}
