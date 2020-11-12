using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: SailorSoda.cs
* Purpose: Class representing data for the Sailor Soda menu item
*/
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the soda based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.07;
                    case Size.Medium:
                        return 1.74;
                    case Size.Small:
                    default:
                        return 1.42;
                }
            }
        }

        /// <summary>
        /// Gets the calories of the soda based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 205;
                    case Size.Medium:
                        return 153;
                    case Size.Small:
                    default:
                        return 117;
                }
            }
        }

        /// <summary>
        /// Backing variable for Ice property
        /// </summary>
        private bool ice = true;

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
        /// Backing variable for Flavor property
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Holds the flavor of this soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Flavor)));
            }
        }

        /// <summary>
        /// Returns a list of special instructions for this drink
        /// </summary>
        public override List<string> SpecialInstructions {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                    instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Sailor Soda
        /// </summary>
        public override string BaseName => "Sailor Soda";

        /// <summary>
        /// Returns the description of the Sailor Soda
        /// </summary>
        public override string Description =>
            "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

        /// <summary>
        /// Creates a string representation of this drink
        /// </summary>
        /// <returns>A string with the format "[Size] [Flavor] Sailor Soda"</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} Sailor Soda", Size.ToString(), Flavor.ToString());
        }
    }
}
