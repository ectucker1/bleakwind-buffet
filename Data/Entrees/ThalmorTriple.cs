using System.Collections.Generic;

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
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// Stores true if the bun should be left on this burger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Stores true if ketchup should be left on this burger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Stores true if mustard should be left on this burger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Stores true if pickes should be left on this burger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Stores true if cheese should be left on this burger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Stores true if tomato should be left on this burger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Stores true if lettuce should be left on this burger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Stores true if mayo should be left on this burger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Stores true if bacon should be left on this burger
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Stores true if egg should be left on this burger
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Returns a list of special instructions for this burger
        /// </summary>
        public List<string> SpecialInstructions
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
