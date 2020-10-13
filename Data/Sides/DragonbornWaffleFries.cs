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
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// Gets the price of the fries based on size
        /// </summary>
        public override double Price
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
        /// Gets the calories of the fries based on size
        /// </summary>
        public override uint Calories
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
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Dragonborn Waffle Fries
        /// </summary>
        public override string BaseName => "Dragonborn Waffle Fries";

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
