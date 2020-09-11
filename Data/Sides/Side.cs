using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: Side.cs
* Purpose: Base class for all side data
*/
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class with common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Stores the size of the side
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the side for its size
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side in its size
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A list of special instructions for the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
