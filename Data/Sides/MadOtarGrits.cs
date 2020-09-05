using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: MadOtarGrits.cs
* Purpose: Class representing data for the Mad Otar Grits menu item
*/
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Stores the price calories, name, and size for the Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the grits based on size
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.93;
                    case Size.Medium:
                        return 1.58;
                    case Size.Small:
                    default:
                        return 1.22;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the grits based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 179;
                    case Size.Medium:
                        return 142;
                    case Size.Small:
                    default:
                        return 105;
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
        /// <returns>A string with the format "[Size] Mad Otar Grits"</returns>
        public override string ToString()
        {
            return string.Format("{0} Mad Otar Grits", Size.ToString());
        }
    }
}
