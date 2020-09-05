﻿using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: AretinoAppleJuice.cs
* Purpose: Class representing data for the Aretino Apple Juice menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the juice based on size
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.01;
                    case Size.Medium:
                        return 0.87;
                    case Size.Small:
                    default:
                        return 0.62;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the juice based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 132;
                    case Size.Medium:
                        return 88;
                    case Size.Small:
                    default:
                        return 44;
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
        /// <returns>A string with the format "[Size] Aretino Apple Juice"</returns>
        public override string ToString()
        {
            return string.Format("{0} Aretino Apple Juice", Size.ToString());
        }
    }
}