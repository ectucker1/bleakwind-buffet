using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: ThalmorTriple.cs
* Purpose: Class representing data for the Thalmor Triple menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 943;

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
        /// Backing field for the Bacon property
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// Stores true if bacon should be left on this burger
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Bacon)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Egg property
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Stores true if egg should be left on this burger
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Egg)));
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
                if (!Bacon)
                    instructions.Add("Hold bacon");
                if (!Egg)
                    instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Thalmor Triple
        /// </summary>
        public override string BaseName => "Thalmor Triple";

        /// <summary>
        /// Returns the description of the Thalmor Triple
        /// </summary>
        public override string Description =>
            "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Thalmor Triple"</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
