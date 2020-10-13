using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: GardenOrcOmelette.cs
* Purpose: Class representing data for the Garden Orc Omelette menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Backing field for the Broccoli property
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// Stores true if the omelette should contain broccoli
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                broccoli = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Broccoli)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Mushrooms property
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// Stores true if the omelette should contain mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Mushrooms)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Tomato property
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Stores true if the omelette should contain tomato
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
        /// Backing field for the Cheddar property
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// Stores true if the omelette should contain cheddar
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Cheddar)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Returns a list of special instructions for the omelette
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli)
                    instructions.Add("Hold broccoli");
                if (!Mushrooms)
                    instructions.Add("Hold mushrooms");
                if (!Tomato)
                    instructions.Add("Hold tomato");
                if (!Cheddar)
                    instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the base name of the Garden Orc Omelette
        /// </summary>
        public override string BaseName => "Garden Orc Omelette";

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Garden Orc Omelette"</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
