using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: DoubleDraugr.cs
* Purpose: Class representing data for the Double Draugr menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        /// Backing field for the Bun property
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Stores true if the bun should be left on this burger
        /// </summary>
        public bool Bun
        {
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
        /// Backing field for the Tomato property
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Stores true if tomato should be left on this burger
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Tomato)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Lettuce property
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Stores true if lettuce should be left on this burger
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Lettuce)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Mayo property
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Stores true if mayo should be left on this burger
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Mayo)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Returns a list of special instructions for this burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
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
                if (!Tomato)
                    instructions.Add("Hold tomato");
                if (!Lettuce)
                    instructions.Add("Hold lettuce");
                if (!Mayo)
                    instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Double Draugr
        /// </summary>
        public override string BaseName => "Double Draugr";

        /// <summary>
        /// Returns the description of the Double Draugr
        /// </summary>
        public override string Description =>
            "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Double Draugr"</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
