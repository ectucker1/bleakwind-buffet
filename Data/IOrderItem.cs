using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: IOrderItem.cs
* Purpose: Interface implemented by all items on the menu
*/
namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface implemented by all items on the menu
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
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
        /// A string representation of this menu item, without any additional modifiers
        /// </summary>
        string BaseName { get; }

        /// <summary>
        /// A string description of this menu item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// A list of special instructions for this menu item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
