using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: VokunSalad.cs
* Purpose: Class representing data for the Vokun Salad menu item
*/
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Stores the price calories, name, and size for the Vokun Salad
    /// </summary>
    public class VokunSalad
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
                        return 1.82;
                    case Size.Medium:
                        return 1.28;
                    case Size.Small:
                    default:
                        return 0.93;
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
                        return 73;
                    case Size.Medium:
                        return 52;
                    case Size.Small:
                    default:
                        return 41;
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
        /// <returns>A string with the format "[Size] Vokun Salad"</returns>
        public override string ToString()
        {
            return string.Format("{0} Vokun Salad", Size.ToString());
        }
    }
}
