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
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// Gets the price of the grits based on size
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Mad Otar Grits
        /// </summary>
        public override string BaseName => "Mad Otar Grits";

        /// <summary>
        /// Returns the description of the Mad Otar Grits
        /// </summary>
        public override string Description =>
            "Cheesey Grits.";

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
