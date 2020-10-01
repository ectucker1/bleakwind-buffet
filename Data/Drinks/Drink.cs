using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: Drink.cs
* Purpose: Base class for all drink data
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class with common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Backing field for Size property
        /// </summary>
        protected Size size = Size.Small;

        /// <summary>
        /// Stores the size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets the price of the drink for its size
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink in its size
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A list of special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
