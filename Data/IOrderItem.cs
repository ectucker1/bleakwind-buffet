using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: Drink.cs
* Purpose: Interface implemented by all items on the menu
*/
namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface implemented by all items on the menu
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this menu item in USD
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The number of calories in this menu item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// A list of special instructions for this menu item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
