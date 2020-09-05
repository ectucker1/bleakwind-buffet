using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: CandlehearthCoffee.cs
* Purpose: Class representing data for the Candlehearth Coffee menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the coffee based on size
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Small:
                    default:
                        return 0.75;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the coffee based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 20;
                    case Size.Medium:
                        return 10;
                    case Size.Small:
                    default:
                        return 7;
                }
            }
        }

        /// <summary>
        /// Stores true if this drink should be served with ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Stores true if cream should be added
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Stores true if the coffee should be made decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                if (RoomForCream)
                    instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Creates a string representation of this drink
        /// </summary>
        /// <returns>A string with the format "[Size] [Decaf?] Candlehearth Coffee"</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return string.Format("{0} Decaf Candlehearth Coffee", Size.ToString());
            }
            else
            {
                return string.Format("{0} Candlehearth Coffee", Size.ToString());
            }
        }
    }
}
