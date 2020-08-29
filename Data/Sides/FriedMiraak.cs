﻿using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: FriedMiraak.cs
* Purpose: Class representing data for the Fried Miraak menu item
*/
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Stores the price calories, name, and size for the Fried Miraak
    /// </summary>
    public class FriedMiraak
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
                        return 2.88;
                    case Size.Medium:
                        return 2.01;
                    case Size.Small:
                    default:
                        return 1.78;
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
                        return 306;
                    case Size.Medium:
                        return 236;
                    case Size.Small:
                    default:
                        return 151;
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
        /// <returns>A string with the format "[Size] Fried Miraak"</returns>
        public override string ToString()
        {
            return string.Format("{0} Fried Miraak", Size.ToString());
        }
    }
}
