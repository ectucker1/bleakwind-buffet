using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: Entree.cs
* Purpose: Base class for all entree data
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class with common properties of all entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A list of special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
