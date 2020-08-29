using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: SailorSoda.cs
* Purpose: Class representing data for the Sailor Soda menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Sailor Soda
    /// </summary>
    public class SailorSoda
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
                        return 2.07;
                    case Size.Medium:
                        return 1.74;
                    case Size.Small:
                    default:
                        return 1.42;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Small:
                    default:
                        return 205;
                }
            }
        }

        /// <summary>
        /// Stores true if this drink should be served with ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Holds the flavor of this soda
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        /// <summary>
        /// Returns a list of special instructions for this drink
        /// </summary>
        public List<string> SpecialInstructions {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                    instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Creates a string representation of this drink
        /// </summary>
        /// <returns>A string with the format "[Size] [Flavor] Sailor Soda"</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} Sailor Soda", Size.ToString(), Flavor.ToString());
        }
    }
}
