using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: BriarheartBurger.cs
* Purpose: Class representing data for the Briarheart Burger menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;

        /// <summary>
        /// Backing field for the Bun property
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Stores true if the bun should be left on this burger
        /// </summary>
        public bool Bun {
            get => bun;
            set
            {
                bun = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Bun)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Ketchup property
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Stores true if ketchup should be left on this burger
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Ketchup)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Mustard property
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Stores true if mustard should be left on this burger
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Mustard)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Pickle property
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Stores true if pickes should be left on this burger
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Pickle)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Cheese property
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Stores true if cheese should be left on this burger
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Cheese)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Returns a list of special instructions for this burger
        /// </summary>
        public override List<string> SpecialInstructions {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun)
                    instructions.Add("Hold bun");
                if (!Ketchup)
                    instructions.Add("Hold ketchup");
                if (!Mustard)
                    instructions.Add("Hold mustard");
                if (!Pickle)
                    instructions.Add("Hold pickle");
                if (!Cheese)
                    instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Briarheart Burger
        /// </summary>
        public override string BaseName => "Briarheart Burger";

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
