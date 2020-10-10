using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: MarkarthMilk.cs
* Purpose: Class representing data for the Markarth Milk menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the milk based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.22;
                    case Size.Medium:
                        return 1.11;
                    case Size.Small:
                    default:
                        return 1.05;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the milk based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 93;
                    case Size.Medium:
                        return 72;
                    case Size.Small:
                    default:
                        return 56;
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
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Ice)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
        /// <returns>A string with the format "[Size] Markarth Milk"</returns>
        public override string ToString()
        {
            return string.Format("{0} Markarth Milk", Size.ToString());
        }
    }
}
