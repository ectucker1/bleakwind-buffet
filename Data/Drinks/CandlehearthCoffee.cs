using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: CandlehearthCoffee.cs
* Purpose: Class representing data for the Candlehearth Coffee menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the coffee based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Small:
                    default:
                        return 0.75;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the coffee based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 20;
                    case Size.Medium:
                        return 10;
                    case Size.Small:
                    default:
                        return 7;
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
        /// Backing variable for RoomForCream property
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// Stores true if cream should be added
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(RoomForCream)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing variable for Decaf property
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// Stores true if the coffee should be made decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Decaf)));
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
                if (RoomForCream)
                    instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Candlehearth Coffee
        /// </summary>
        public override string BaseName => "Candlehearth Coffee";

        /// <summary>
        /// Returns the description of the Candlehearth Coffee
        /// </summary>
        public override string Description =>
            "Fair trade, fresh ground dark roast coffee.";

        /// <summary>
        /// Creates a string representation of this drink
        /// </summary>
        /// <returns>A string with the format "[Size] [Decaf?] Candlehearth Coffee"</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return string.Format("{0} Decaf Candlehearth Coffee", Size.ToString());
            }
            else
            {
                return string.Format("{0} Candlehearth Coffee", Size.ToString());
            }
        }
    }
}
