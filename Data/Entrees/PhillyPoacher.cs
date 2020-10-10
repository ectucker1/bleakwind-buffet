using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: PhillyPoacher.cs
* Purpose: Class representing data for the Philly Poacher menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Philly Poacher
    /// </summary>
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Backing field for the Sirloin property
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// Stores true if the sandwich should have sirloin
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Sirloin)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Onion property
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Stores true if the sandwich should have onions
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Onion)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Roll property
        /// </summary>
        private bool roll = true;

        /// <summary>
        /// Stores true if the sandwich should come on a roll
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Roll)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Returns a list of special instructions for the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin)
                    instructions.Add("Hold sirloin");
                if (!Onion)
                    instructions.Add("Hold onions");
                if (!Roll)
                    instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Philly Poacher"</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
