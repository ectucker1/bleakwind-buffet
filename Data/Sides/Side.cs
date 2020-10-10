using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

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
        /// Event handler called whenever a property changes on this side
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Backing field for the Size property
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Stores the size of the side
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
