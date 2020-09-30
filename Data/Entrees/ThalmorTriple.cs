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
        /// Event handler called whenever a property changes on this menu item
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bun)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Ketchup)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Mustard)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Pickle)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cheese)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tomato)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lettuce)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Mayo)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bacon)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Egg)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialInstructions)));
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
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Thalmor Triple"</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
