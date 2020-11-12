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
        /// Event handler called whenever a property changes on this drink
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Backing field for the Size property
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Stores the size of the drink
        /// </summary>
        public Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Size)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Price)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Calories)));
            }
        }

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

        /// <summary>
        /// The base name of this drink
        /// </summary>
        public abstract string BaseName { get; }

        /// <summary>
        /// The description of this drink
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Raises a PropertyChangedEvent from a child class
        /// </summary>
        /// <param name="e">Arguments for the property changed event arguments</param>
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
