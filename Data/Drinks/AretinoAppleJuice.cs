﻿using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

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
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler called whenever a property changes on this drink
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores the size of this drink
        /// </summary>
        public override Size Size
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
        /// Gets the price of the juice based on size
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        /// Backing variable for Ice property
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Stores true if this drink should be served with ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Ice)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Returns a list of special instructions for this drink
        /// </summary>
        public override List<string> SpecialInstructions
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
