using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: DragonbornWaffleFries.cs
* Purpose: Class representing data for the Dragonborn Waffle Fries menu item
*/
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Stores the price calories, name, and size for the Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 0.96;
                    case Size.Medium:
                        return 0.76;
                    case Size.Small:
                    default:
                        return 0.42;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 100;
                    case Size.Medium:
                        return 89;
                    case Size.Small:
                    default:
                        return 77;
                }
            }
        }

        /// <summary>
        /// Returns a list of special instructions for this side
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Creates a string representation of this side
        /// </summary>
        /// <returns>A string with the format "[Size] Dragonborn Waffle Fries"</returns>
        public override string ToString()
        {
            return string.Format("{0} Dragonborn Waffle Fries", Size.ToString());
        }
    }
}
